
using System;

namespace JTTT_1._0
{

    public abstract class IAction
    {
        public int Id { get; set; }
      //  public virtual Task Task { get; set; }
        public abstract string GetActionName();
        public abstract string[] DoAction(IModel model);
        public abstract IModel GetEmptyModel();
        public abstract ActionView GetView();
    }
}

   
