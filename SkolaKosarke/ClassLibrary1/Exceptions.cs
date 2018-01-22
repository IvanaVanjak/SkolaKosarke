using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Model
{
    public class Exceptions
    {
    }
    [Serializable]
    public class SkolaKosarkeBaseException : Exception
    {
    }

    [Serializable]
    public class IgracOIBAlreadyExists : SkolaKosarkeBaseException
    {

    }


    [Serializable]
    public class IgracPraznoPolje : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class IgracDoesntExists : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class IgracNadimakAlreadyExists : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class KlubAlreadyExists : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class KlubPraznoPolje : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class NatjecanjeNazivPrazno : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class GrupaTreningaAlreadyExists : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class GrupaTreningaPraznoImeExists : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class OIBFormatException : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class OIBLengthException : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class NatjecanjeAlreadyExists : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class NatjecanjeDoesntExists : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class UtakmicaDoesntExists : SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class StatistikaDoesntExists : SkolaKosarkeBaseException
    {

    }


    [Serializable]
    public class BiljeskaTekstPrazno :SkolaKosarkeBaseException
    {

    }

    [Serializable]
    public class ClanarinaAlreadyExists: SkolaKosarkeBaseException
    {

    }
}
