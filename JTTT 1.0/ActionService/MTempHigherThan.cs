
using System;

namespace JTTT_1._0
{
    class MTempHigherThan : IModel
    {

        public string City { get; set; }
        public float TempTrigger { get; set; }

        public override void Complemet(string[] args)
        {
            throw new NotImplementedException();
        }

        public override void FillModel(string[] args)
        {
            City = args[0];
            TempTrigger = float.Parse(args[1]);
        }
    }
}
