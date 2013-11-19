using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;

namespace WindowsFormsApplication6
{
    
    class Mensagem
    {
        //ATRIBUTOS
        Note nota;       
        int oitava;
        int BPM;
        bool repetição;
        Mensagem próxima;

        //SETS
        void setNota(char letra)
        {
            nota = new Note(letra);
        }
        void setOitava(int novaOitava)
        {
            oitava = novaOitava;
        }
        void setBPM(int novoBPM)
        {
            BPM = novoBPM;
        }
        void setRepetição(bool repete)
        {
            repetição = repete;
        }

        //GETS
        Pitch getPitch()
        {
            Pitch pitch;
            pitch = nota.PitchInOctave(oitava);
            return (pitch);
        }
        int getBPM()
        {
            return BPM;
        }
    }
}
