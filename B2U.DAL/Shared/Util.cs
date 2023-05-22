using B2U.DAL.Domain;

namespace B2U.DAL.Shared;

public static class Util
{

    public static bool ValidateTransacao(this Transacao transacao)
    {
        bool isValid = true;

        if (transacao == null)
            return isValid = false;

        if (transacao.Historico == null || transacao.Historico == "")
            return isValid = false;

        if (transacao.Data == DateTime.MinValue)
            return isValid = false;

        if (transacao.Data.Date > DateTime.Now.Date)
            return isValid = false;

        if (transacao.Debito < 0)
            return isValid = false;

        if (transacao.Credito < 0)
            return isValid = false;

        if (transacao.Notas == null || transacao.Notas == "")
            return isValid = false;

        return isValid;
    }
}