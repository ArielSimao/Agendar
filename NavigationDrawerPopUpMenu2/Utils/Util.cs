using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Agendar.Utils {
    class Util {
        
        // estados
        public static List<string> ListaEstado() {
            List<string> listaEstado = new List<string>();
            string acre = "AC";
            listaEstado.Add(acre);
            string alagoas = "AL";
            listaEstado.Add(alagoas);
            string amapa = "AP";
            listaEstado.Add(amapa);
            string amazonas = "AM";
            listaEstado.Add(amazonas);
            string bahia = "BA";
            listaEstado.Add(bahia);
            string ceara = "CE";
            listaEstado.Add(ceara);
            string df = "DF";
            listaEstado.Add(df);
            string es = "ES";
            listaEstado.Add(es);
            string goias = "GO";
            listaEstado.Add(goias);
            string maranhao = "MA";
            listaEstado.Add(maranhao);
            string mg = "MT";
            listaEstado.Add(mg);
            string mgs = "MS";
            listaEstado.Add(mgs);
            string minas = "MG";
            listaEstado.Add(minas);
            string para = "PA";
            listaEstado.Add(para);
            string paraiba = "PB";
            listaEstado.Add(paraiba);
            string parana = "PR";
            listaEstado.Add(parana);
            string pernanbuco = "PE";
            listaEstado.Add(pernanbuco);
            string piaui = "PI";
            listaEstado.Add(piaui);
            string rio = "RJ";
            listaEstado.Add(rio);
            string rgn = "RN";
            listaEstado.Add(rgn);
            string rgs = "RS";
            listaEstado.Add(rgs);
            string rondonia = "RO";
            listaEstado.Add(rondonia);
            string roraima = "RR";
            listaEstado.Add(roraima);
            string sc = "SC";
            listaEstado.Add(sc);
            string spaulo = "SP";
            listaEstado.Add(spaulo);
            string sergipe = "SE";
            listaEstado.Add(sergipe);
            string tocantins = "TO";
            listaEstado.Add(tocantins);

            return listaEstado;
        }
        // horarios
        public static List<string> horarios(){
            List<string> listaHorario = new List<string>();
            // AM
            string num6 = "06:00"; listaHorario.Add(num6);
            string _num6 = "06:30"; listaHorario.Add(_num6);
            string num7 = "07:00"; listaHorario.Add(num7);
            string _num7 = "07:30"; listaHorario.Add(_num7);
            string num8 = "08:00"; listaHorario.Add(num8);
            string _num8 = "08:30"; listaHorario.Add(_num8);
            string num9 = "09:00"; listaHorario.Add(num9);
            string _num9 = "09:30"; listaHorario.Add(_num9);
            string num10 = "10:00"; listaHorario.Add(num10);
            string _num10 = "10:30"; listaHorario.Add(_num10);
            string num11 = "11:00"; listaHorario.Add(num11);
            string _num11 = "11:30"; listaHorario.Add(_num11);
            string num12 = "12:00"; listaHorario.Add(num12);
            string _num12 = "12:30"; listaHorario.Add(_num12);
            //________________________________________________
            string space = "______"; listaHorario.Add(space);
            // PM
            string num13 = "13:00"; listaHorario.Add(num13);
            string _num13 = "13:30"; listaHorario.Add(_num13);
            string num14 = "14:00"; listaHorario.Add(num14);
            string _num14 = "14:30"; listaHorario.Add(_num14);
            string num15 = "15:00"; listaHorario.Add(num15);
            string _num15 = "15:30"; listaHorario.Add(_num15);
            string num16 = "16:00"; listaHorario.Add(num16);
            string _num16 = "16:30"; listaHorario.Add(_num16);
            string num17 = "17:00"; listaHorario.Add(num17);
            string _num17 = "17:30"; listaHorario.Add(_num17);
            string num18 = "18:00"; listaHorario.Add(num18);
            string _num18 = "18:30"; listaHorario.Add(_num18);
            string num19 = "19:00"; listaHorario.Add(num19);
            string _num19 = "19:30"; listaHorario.Add(_num19);
            string num20 = "20:00"; listaHorario.Add(num20);
            string _num20 = "20:30"; listaHorario.Add(_num20);
            string num21 = "21:00"; listaHorario.Add(num21);
            string _num21 = "21:30"; listaHorario.Add(_num21);
            string num22 = "22:00"; listaHorario.Add(num22);
            string _num22 = "22:30"; listaHorario.Add(_num22);

            return listaHorario;
        }

        // criptografia
        // encrypto
        private static string IV = "CesSistemasCopyR";
        private static string cryptoKey = "CesSistemasDireitosReservadosCes";
        public static string encrypt(string texto){
            try {
                if (!string.IsNullOrEmpty(texto)) {
 
                    byte[] key = UTF32Encoding.ASCII.GetBytes(cryptoKey);
                    byte[] text = UTF8Encoding.ASCII.GetBytes(texto);
                    byte[] iv = UTF8Encoding.ASCII.GetBytes(IV);

                    Rijndael rj = new RijndaelManaged();
                    rj.Mode = CipherMode.CBC;
                    rj.KeySize = 256;
                    rj.BlockSize = 128;

                    MemoryStream mstream = new MemoryStream();
                    CryptoStream encryptor = new CryptoStream(mstream, rj.CreateEncryptor(key,iv), CryptoStreamMode.Write);
                    encryptor.Write(text, 0, text.Length);
                    encryptor.FlushFinalBlock();

                    return Convert.ToBase64String(mstream.ToArray());

                }
                else {
                    return null;
                }
            }catch(Exception ex){
                throw new ApplicationException(ex.Message, ex);
            }

        }
        // decrypt
        public static string decrypt(string texto) {
            try {
                if (!string.IsNullOrEmpty(texto)) {
                    byte[] key = UTF8Encoding.ASCII.GetBytes(cryptoKey);
                    byte[] text = Convert.FromBase64String(texto);
                    byte[] iv = UTF8Encoding.ASCII.GetBytes(IV);

                    Rijndael rj = new RijndaelManaged();
                    rj.KeySize = 256;
                    rj.BlockSize = 128;

                    MemoryStream mstream = new MemoryStream();
                    CryptoStream encryptor = new CryptoStream(mstream, rj.CreateDecryptor(key, iv), CryptoStreamMode.Write);
                    encryptor.Write(text, 0, text.Length);
                    encryptor.FlushFinalBlock();

                    UTF8Encoding utf8 = new UTF8Encoding();
                    return utf8.GetString(mstream.ToArray());

                }
                else {
                    return null;
                }
            }
            catch (Exception ex) {
                throw new ApplicationException(ex.Message, ex);
            }

        }
    }
}
