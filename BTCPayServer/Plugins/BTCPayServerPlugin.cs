using BTCPayServer.Abstractions.Models;
using BTCPayServer.Models;

namespace BTCPayServer.Plugins
{
    public class BTCPayServerPlugin : BaseBTCPayServerPlugin
    {
        public override string Identifier { get; } = nameof(BTCPayServer);
        public override string Name { get; } = "ZEUSPay";
        public override string Description { get; } = "ZEUSPay core system";

    }
}
