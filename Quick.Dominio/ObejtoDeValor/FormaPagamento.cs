using Quick.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quick.Dominio.ObjetoDe
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamentosEnum.Boleto;}
        }
        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentosEnum.CartaoCredito; }
        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentosEnum.Deposito; }
        }

        public bool NaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentosEnum.NaoDefinido; }
        }

    }
}
