using Assets.HAVIR.Scripts.Game.Main.GraphModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

/// <summary>
/// Clase que maneja el reconocedor de palabras claves y las acciones que debe ejecutar
/// </summary>
public class UnityKeywordRecognizerController : IDisposable
{

    //private KeywordRecognizer _recognizer;
    //private Answer _arista;
    //private Question _sourceNode;

    //public KeywordRecognizer Recognizer { get { return _recognizer; } }

    //public UnityKeywordRecognizerController(Question sourceNode, Answer arista, List<string> newKeywords)
    //{
    //    if (newKeywords.Any())
    //        _recognizer = new KeywordRecognizer(newKeywords.ToArray());
    //    else
    //        _recognizer = new KeywordRecognizer(new string[] { Guid.NewGuid().ToString() });

    //    _recognizer.OnPhraseRecognized += OnPhraseRecognizedHandler;
    //    _arista = arista;
    //    _sourceNode = sourceNode;
    //    //_recognizer.Start();
    //}

    public void Dispose()
    {
        //_recognizer.Stop();
        //_recognizer.Dispose();
    }
}
