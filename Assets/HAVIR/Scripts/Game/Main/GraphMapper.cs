using Assets.HAVIR.Scripts.Game.Main.GraphModel;
using Assets.HAVIR.Scripts.Game.Speech;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Assets.HAVIR.Scripts.Game.Main
{
    public class GraphMapper
    {
        public static List<Question> GetGraphNodes()
        {
            var graph = new List<Question>();
            //var graphMl = MapFromXml();
            var xml = XElement.Load(@"C:\Users\Lucho\Documents\En ejecución\Proyectos\UAN\HAVIR\Assets\HAVIR\Scripts\Game\Main\GraphModel\BasicDialog.graphml");

            var graphXml = xml.Elements("{http://graphml.graphdrawing.org/xmlns}graph");

            foreach (var node in graphXml.Elements("{http://graphml.graphdrawing.org/xmlns}node"))
            {
                var d5 = node.Elements("{http://graphml.graphdrawing.org/xmlns}data").FirstOrDefault(x => x.Attribute("key").Value.Equals("d5"));
                var d6 = node.Elements("{http://graphml.graphdrawing.org/xmlns}data").FirstOrDefault(x => x.Attribute("key").Value.Equals("d6"));
                string
                    id = node.Attribute("id").Value,
                    description = "",
                    audio = "",
                    animation = "";
                if (d5 != null)
                {
                    var data = d5.Value.Split('|');
                    description = data[0];
                    audio = data.Any(x => x.StartsWith("@audio")) ? string.Empty : data.FirstOrDefault(x => x.StartsWith("@audio"));
                    animation = data.Any(x => x.StartsWith("@animation")) ? string.Empty : data.FirstOrDefault(x => x.StartsWith("@animation"));
                }

                var genericNode = (XElement)d6.FirstNode;
                var type = genericNode.Attribute("configuration").Value;

                var targetEdges = graphXml.Elements("{http://graphml.graphdrawing.org/xmlns}edge").Where(x => x.Attribute("target").Value == id);
                var graphNode = new Question(id, description, audio, animation, _getNodeType(type), targetEdges.Any());
                var sourceEdges = graphXml.Elements("{http://graphml.graphdrawing.org/xmlns}edge")
                       .Where(x => x.Attribute("source").Value == id);

                foreach (var edge in sourceEdges)
                {
                    var edgeData = edge.Elements("{http://graphml.graphdrawing.org/xmlns}data").FirstOrDefault(x => x.Attribute("key").Value.Equals("d9"));
                    var arista = new Answer() { TargetId = edge.Attribute("target").Value };
                    arista.Choices = new List<string>();
                    List<string> tempChoices;
                    if (edgeData != null)
                        foreach (var option in edgeData.Value.Split(','))
                        {
                            if (PredefinedAnswers.dictionary.TryGetValue(edgeData.Value, out tempChoices))
                                arista.Choices.AddRange(tempChoices);
                            else
                                arista.Choices.Add(option);
                        }

                    graphNode.AddArista(arista);
                }
                graph.Add(graphNode);
            }


            return graph;
        }

        private static NodeType _getNodeType(string type)
        {
            if (type == "com.yworks.flowchart.decision")
                return NodeType.Decision;
            else if (type == "com.yworks.flowchart.data")
                return NodeType.Data;
            else if (type == "com.yworks.flowchart.start1" || type == "com.yworks.flowchart.start2")
                return NodeType.Start;
            return NodeType.Terminator;
        }

        public static graphml MapFromXml()
        {
            // Create an instance of the XmlSerializer specifying type and namespace.
            XmlSerializer serializer = new
            XmlSerializer(typeof(graphml));

            // A FileStream is needed to read the XML document.
            FileStream fs = new FileStream(@"C:\Users\Lucho\Documents\En ejecución\Proyectos\UAN\HAVIR\Assets\HAVIR\Scripts\Game\Main\GraphModel\BasicDialog.graphml", FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);

            // Declare an object variable of the type to be deserialized.
            graphml graph;

            // Use the Deserialize method to restore the object's state.
            graph = (graphml)serializer.Deserialize(reader);
            fs.Close();
            return graph;
        }
    }
}
