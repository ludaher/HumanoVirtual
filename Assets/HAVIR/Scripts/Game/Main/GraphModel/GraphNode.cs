using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.HAVIR.Scripts.Game.Main.GraphModel
{
    public class Question
    {
        private List<Answer> _answer;
        private bool _isRoot;
        private string _id;

        public Question Parent { get; set; }
        public string Id { get { return _id; } }
        public string Description { get; set; }
        public string Audio { get; set; }
        public string Animation { get; set; }

        public NodeType Type { get; set; }
        public bool IsRoot { get { return _isRoot; } }
        public Action<string> GraphAction { get; set; }
        public List<Answer> Answer { get { return _answer; } }
        public bool IsRunning { get; set; }

        public Question(string id, string description, string audio,
            string animation, NodeType nodeType, bool isRoot)
        {
            _id = id;
            Description = description;
            Audio = audio;
            Animation = animation;
            _isRoot = isRoot;
            _answer = new List<Answer>();
            Type = nodeType;
            GraphAction = (string keyword) =>
            {
                if (Parent != null)
                    Parent.IsRunning = false;
                IsRunning = true;
                if (string.IsNullOrWhiteSpace(this.Audio) || this.Audio == "#value" )
                    VoiceManager.Instance.AddToSpeechQueue(this.Description);
                else
                    VoiceManager.Instance.AddToSpeechQueue(this.Audio);
                if (Type != NodeType.Decision)
                {
                    var nextQuestion = _answer.Select(x => x.Target).FirstOrDefault();
                    if(nextQuestion != null)
                    {
                        nextQuestion.Execute();
                    }
                }

            };
        }

        internal void Execute()
        {
            GraphAction.Invoke("");
        }

        public void AddArista(Answer arista)
        {
            if (Type != NodeType.Decision && _answer.Any())
                throw new Exception("Los únicos nodos que permiten múltiples salidas, son los nodos de decisión.");
            _answer.Add(arista);
        }

        public void AddArista(List<Answer> aristas)
        {
            if (Type != NodeType.Decision && _answer.Any())
                throw new Exception("Los únicos nodos que permiten múltiples salidas, son los nodos de decisión.");
            if (Type != NodeType.Decision && aristas.Count > 1)
                throw new Exception("Los únicos nodos que permiten múltiples salidas, son los nodos de decisión.");
            _answer.AddRange(aristas);
        }

        public Answer FindArista(string option)
        {
            return _answer.FirstOrDefault(x => x.Choices.Any(o => o.Equals(option)));
        }
    }

    public class Answer
    {
        public string TargetId { get; set; }
        public Question Target { get; set; }
        public List<string> Choices { get; set; }
    }

    public enum NodeType
    {
        Start,
        Terminator,
        Data,
        Decision

    }
}
