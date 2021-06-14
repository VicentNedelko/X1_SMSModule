using System;
using System.Threading.Tasks;
using LogicModule.Nodes.Helpers;
using LogicModule.Nodes.TestHelper;
using LogicModule.ObjectModel;
using LogicModule.ObjectModel.TypeSystem;

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
            this.Send = typeService.CreateBool(PortTypes.Binary, "Send", false);
            this.Phone = typeService.CreateString(PortTypes.String, "Phone", "1016666");
            this.Message = typeService.CreateString(PortTypes.String, "Message", "");
            this.Status = typeService.CreateString(PortTypes.String, "SMS Status");
        }

        [Input(IsInput = true, IsRequired = true, DisplayOrder = 1)]
        public BoolValueObject Send { get; private set; }
        
        [Input(IsInput = false, IsRequired = true, DisplayOrder = 2)]
        public StringValueObject Phone { get; private set; }

        [Input(IsInput = false, IsRequired = true, DisplayOrder = 3)]
        public StringValueObject Message { get; private set; }

        [Output(IsRequired = true)]
        public StringValueObject Status { get; set; }

        public async Task Execute()
        {
            if(Send.HasValue == true)
            {
                SMSManager smsManager = new();
                Status.BlockGraph();
                var getSmsStatus = await smsManager.SendAsync(Message, Phone);
                Status.Value = getSmsStatus.Dlr_status;
            }
            
        }

    }
}
