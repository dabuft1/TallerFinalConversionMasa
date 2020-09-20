using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerFinalConversionMasa
{
    public class ConvertirMasa : Conversion
    {
        public double ConvertirAGramas() {
            return (this.getKilogramo() * 1000);
        }
        public double CovertirADecagramos() {
            return (this.getKilogramo() * 100);
        }
        public double ConvertirAMiligramos() {
            return (this.getKilogramo() * 1000000);
        }
    }
}
