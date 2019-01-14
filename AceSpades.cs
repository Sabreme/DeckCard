using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    class AceSpades : Card
    {

        public AceSpades(string name)
        {
            Name = name;
        }

        public void SetValue(Value_Type value)
        {
            Value = value;
        }

        public override void ChangeSuite(Suite_Type suite)
        {
            this.Suite = suite;
        }
    }
}
