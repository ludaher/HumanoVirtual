using System;
using System.Collections;
using System.Collections.Generic;
//using System.Speech.Recognition;
using UnityEngine;
using System.Linq;
using Assets.HAVIR.Scripts.Game.Main.GraphModel;

public class WindowsVoiceRecognizer : IVoiceRecognizer
{
    //private WindowsSpeech speech;

    //private WindowsSpeech Speech { get {
    //        if (speech == null)
    //            speech = new WindowsSpeech(new System.Globalization());
    //        return speech; } }

    public WindowsVoiceRecognizer()
    {

    }

    public Guid AddKeywordRecognition(Question sourceNode, Answer arista, bool startInmmediately = false)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
    }

    //SpeechRecognizer recognizer;

    //public WindowsVoiceRecognizer() {
    //    recognizer = new SpeechRecognizer();
    //}

    //public Guid AddKeywordRecognition(Dictionary<string, Action> keywords, bool startInmmediately = false)
    //{
    //    Choices choices = new Choices();
    //    choices.Add(keywords.Keys.ToArray());

    //    // Create a GrammarBuilder object and append the Choices object.
    //    GrammarBuilder gb = new GrammarBuilder();
    //    gb.Append(choices);

    //    // Create the Grammar instance and load it into the speech recognition engine.
    //    var id = Guid.NewGuid();
    //    Grammar g = new Grammar(gb);
    //    g.Name = id.ToString();
    //    recognizer.LoadGrammar(g);
    //    return id;
    //}

    //public void Dispose()
    //{
    //    if (recognizer == null)
    //        return;
    //    recognizer.Dispose();
    //}

    public void InitRecognizer(bool dictation, bool keywordRecognation)
    {
        throw new NotImplementedException();
    }

    public void RemoveKeywordRecognition(Guid id)
    {
        throw new NotImplementedException();
    }

    public void StopKeywordRecognition(Guid id)
    {
        throw new NotImplementedException();
    }
}
