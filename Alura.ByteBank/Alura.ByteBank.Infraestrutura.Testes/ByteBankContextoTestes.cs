using Alura.ByteBank.Dados.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Alura.ByteBank.Infraestrutura.Testes
{
    public class ByteBankContextoTestes
    {
        [Fact]
        public void TestaConexaoContextoComMySQL()
        {
            var contexto = new ByteBankContexto();
            bool conectado;

            try
            {
                conectado = contexto.Database.CanConnect();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível conectar a base de dados");

            }

            Assert.True(conectado);
        }
    }
}
