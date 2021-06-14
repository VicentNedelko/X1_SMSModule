using System;
using LogicModule.Nodes.Helpers;
using LogicModule.Nodes.TestHelper;
using LogicModule.ObjectModel;

namespace X1_TestModule
{
    public class LogicNodeSMSSender : LogicNodeBase
    {

        private readonly ITypeService typeService;
        public LogicNodeSMSSender(INodeContext context)
            : base(context)
        {
            context.ThrowIfNull("context");

            this.typeService = context.GetService<ITypeService>();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Startup()
        {
            throw new NotImplementedException();
        }

    }
}
