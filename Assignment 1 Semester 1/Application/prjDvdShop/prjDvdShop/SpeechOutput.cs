/*SpeechOut.cs          Author : Duran Moodley
 * Converts a string into Speech Output
 * Date Modified : 6/13/2015
*/
using System.Speech.Synthesis;
namespace prjDvdShop
{
    sealed class SpeechOutput
    {
        //********************************************************************
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
