using System;

namespace Retangulo
{
    class Retangulo
    {
        private double _a, _l; // _a -> Altura ; _l -> Largura
        public string Altura { set => _a = Convert.ToDouble(value); }
        public string Largura { set => _l = Convert.ToDouble(value); }
        public string Area => (_a * _l).ToString();
        public string Perimetro => (2 * (_a + _l)).ToString();
        public string Diagonal => (Math.Sqrt(_l * _l + _a * _a)).ToString();
    }
}
/*        public string Area
 *        {
 *          get
 *          {
 *            return (_a * _l).ToString();
 *          }
 *        }
*/
