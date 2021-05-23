using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sluttest
{
    public class Medlemmar
    {
        int mid;
        String förnamn;
        String efternamn;
        String kön;
        string födelsedag;
        int telefonnumer;
        String mail;
        String tecknat;
        String nivå;
        String period;

        public Medlemmar(int mid, string förnamn, String efternamn, String kön, String födelsedag,int telefonnumer,String mail,String tecknat,String nivå,String period)
        {
            Mid = mid;
            Förnamn = förnamn;
            Efternamn = efternamn;
            Kön = kön;
            Födelsedag = födelsedag;
            Telefonnumer = telefonnumer;
            Mail = mail;
            Tecknat = tecknat;
            Nivå = nivå;
            Period = period;
        }

        public string Förnamn
        {
            get
            {
                return förnamn;
            }

            set
            {
                förnamn = value;
            }
        }

        public string Efternamn
        {
            get
            {
                return efternamn;
            }

            set
            {
                efternamn = value;
            }
        }

        public string Kön
        {
            get
            {
                return kön;
            }

            set
            {
                kön = value;
            }
        }

       
        public int Telefonnumer
        {
            get
            {
                return telefonnumer;
            }

            set
            {
                telefonnumer = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public string Tecknat
        {
            get
            {
                return tecknat;
            }

            set
            {
                tecknat = value;
            }
        }

        public string Nivå
        {
            get
            {
                return nivå;
            }

            set
            {
                nivå = value;
            }
        }

        public string Period
        {
            get
            {
                return period;
            }

            set
            {
                period = value;
            }
        }

        public int Mid
        {
            get
            {
                return mid;
            }

            set
            {
                mid = value;
            }
        }

        public string Födelsedag
        {
            get
            {
                return födelsedag;
            }

            set
            {
                födelsedag = value;
            }
        }
    }
}
