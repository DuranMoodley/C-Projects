/* SpeechOutput.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Converts text to speech
 * Last Modified : 6/16/2015
***********************************************/
using System;
using System.Speech.Synthesis;
namespace prjZooApplication
{
    public sealed class SpeechOutput
    {
        public SpeechOutput()
        {
        }
        //********************************************************************
        public void ConvertTextToSpeech(string text)
        {
            //Instantation
            SpeechSynthesizer objSynthesizer = new SpeechSynthesizer();

            //Set Speech Property
            objSynthesizer.SetOutputToDefaultAudioDevice();

            //Output Speech
            objSynthesizer.Speak(text);

            //Close Synthesizer 
            objSynthesizer.Dispose();
        }

    }
}
