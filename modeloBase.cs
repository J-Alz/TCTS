using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTS
{
    internal class modeloBase
    {
        string lambda = "";
        string miu = "";
        string k = "";
        string n = "";
        string m = "";

        public int Lambda(){ return int.Parse(lambda); }
        public void Lambda(string value){lambda = (value == "") ? "0":value;
            /*if (value == "")
                lambda = "0";
            else
                lambda = value;*/
        }
        //Tiempo de servicio
        public int Miu() { return int.Parse(miu); }
        public void Miu(string value) { miu = (value == "") ? "0" : value; }
        //Servidores
        public int K() { return int.Parse(k); }
        public void K(string value) { k = (value == "") ? "0" : value; }
        //Cantidad de clientes
        public int N() { return int.Parse(n); }
        public void N(string value) { n = (value == "") ? "0" : value; }
        //Poblacion Finita
        public int M() { return int.Parse(m); }
        public void M(string value) { m = (value == "") ? "0" : value; }
        
        
    }
}
