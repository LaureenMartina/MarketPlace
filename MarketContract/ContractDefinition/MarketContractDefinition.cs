using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace MarketPlace.Contracts.MarketContract.ContractDefinition
{


    public partial class MarketContractDeployment : MarketContractDeploymentBase
    {
        public MarketContractDeployment() : base(BYTECODE) { }
        public MarketContractDeployment(string byteCode) : base(byteCode) { }
    }

    public class MarketContractDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60806040526003600055600060015534801561001a57600080fd5b506111528061002a6000396000f3fe6080604052600436106100865760003560e01c8063660861b711610059578063660861b7146101305780636960fbf61461015257806376a48c711461017257806378a949a714610192578063aeda852f146101bb57610086565b806307d6471b1461008b5780633107c99d146100c1578063368ef2b7146100ee5780636478802c1461010e575b600080fd5b34801561009757600080fd5b506100ab6100a6366004610e5d565b6101db565b6040516100b89190611099565b60405180910390f35b3480156100cd57600080fd5b506100e16100dc366004610e80565b6101ed565b6040516100b89190611086565b6101016100fc366004610e98565b6103eb565b6040516100b8919061107b565b34801561011a57600080fd5b5061012e610129366004610e80565b610499565b005b34801561013c57600080fd5b5061014561049c565b6040516100b8919061101b565b34801561015e57600080fd5b5061012e61016d366004610ec7565b610686565b34801561017e57600080fd5b5061012e61018d366004610e80565b610839565b34801561019e57600080fd5b506101a76109c4565b6040516100b89897969594939291906110a2565b3480156101c757600080fd5b506101a76101d6366004610e80565b610b17565b600d6020526000908152604090205481565b6101f5610c42565b60005b6002548110156103e457826002828154811061021057fe5b90600052602060002090600702016000015414156103dc576002818154811061023557fe5b9060005260206000209060070201604051806101000160405290816000820154815260200160018201548152602001600282018054600181600116156101000203166002900480601f0160208091040260200160405190810160405280929190818152602001828054600181600116156101000203166002900480156102fc5780601f106102d1576101008083540402835291602001916102fc565b820191906000526020600020905b8154815290600101906020018083116102df57829003601f168201915b5050509183525050600382015460208083019190915260048301805460408051601f6002600019610100600187161502019094169390930492830185900485028101850182528281529401939283018282801561039a5780601f1061036f5761010080835404028352916020019161039a565b820191906000526020600020905b81548152906001019060200180831161037d57829003601f168201915b5050509183525050600582015460208201526006909101546001600160a01b0381166040830152600160a01b900460ff16151560609091015291506103e69050565b6001016101f8565b505b919050565b60006103f683610bb1565b8015610406575061040683610c0e565b1561048f57816001600160a01b03166108fc6002858154811061042557fe5b9060005260206000209060070201600101549081150290604051600060405180830381858888f19350505050158015610462573d6000803e3d6000fd5b506001600160a01b0382166000908152600d6020526040902083905561048783610839565b506001610493565b5060005b92915050565b50565b60606002805480602002602001604051908101604052809291908181526020016000905b8282101561067c5783829060005260206000209060070201604051806101000160405290816000820154815260200160018201548152602001600282018054600181600116156101000203166002900480601f0160208091040260200160405190810160405280929190818152602001828054600181600116156101000203166002900480156105915780601f1061056657610100808354040283529160200191610591565b820191906000526020600020905b81548152906001019060200180831161057457829003601f168201915b5050509183525050600382015460208083019190915260048301805460408051601f6002600019610100600187161502019094169390930492830185900485028101850182528281529401939283018282801561062f5780601f106106045761010080835404028352916020019161062f565b820191906000526020600020905b81548152906001019060200180831161061257829003601f168201915b505050918352505060058201546020808301919091526006909201546001600160a01b0381166040830152600160a01b900460ff16151560609091015290825260019290920191016104c0565b5050505090505b90565b61068e610c42565b5060408051610100810182528781526020808201888152928201878152606083018790526080830186905260a083018590523360c0840152600060e0840181905260028054600181018255915283517f405787fa12a823e0f2b7631cc41b3ba8828b3321ca811111fa75cd3aa3bb5ace600790920291820190815594517f405787fa12a823e0f2b7631cc41b3ba8828b3321ca811111fa75cd3aa3bb5acf82015590518051939485949093610767937f405787fa12a823e0f2b7631cc41b3ba8828b3321ca811111fa75cd3aa3bb5ad001920190610c92565b50606082015160038201556080820151805161078d916004840191602090910190610c92565b5060a0820151600582015560c08201516006909101805460e0909301511515600160a01b0260ff60a01b196001600160a01b039093166001600160a01b03199485161792909216919091179055600254336000818152600d60205260408120929092556001805481018155600a805491820181559092527fc65a7bb8d6351c1cf70c95a316cc6a92839c986682d98bc35f958f4883f9d2a8909101805490921617905550505050505050565b600254811061084757610499565b805b60025460001901811015610956576002816001018154811061086757fe5b90600052602060002090600702016002828154811061088257fe5b90600052602060002090600702016000820154816000015560018201548160010155600282018160020190805460018160011615610100020316600290046108cb929190610d10565b5060038201548160030155600482018160040190805460018160011615610100020316600290046108fd929190610d10565b5060058281015490820155600691820180549290910180546001600160a01b0319166001600160a01b0390931692909217808355905460ff600160a01b918290041615150260ff60a01b19909116179055600101610849565b5060028054600019810190811061096957fe5b60009182526020822060079091020181815560018101829055906109906002830182610d85565b60038201600090556004820160006109a89190610d85565b506000600582015560060180546001600160a81b031916905550565b600380546004546005805460408051602060026001851615610100026000190190941693909304601f8101849004840282018401909252818152949593949291830182828015610a555780601f10610a2a57610100808354040283529160200191610a55565b820191906000526020600020905b815481529060010190602001808311610a3857829003601f168201915b50505050600383015460048401805460408051602060026001851615610100026000190190941693909304601f81018490048402820184019092528181529596939593945090830182828015610aec5780601f10610ac157610100808354040283529160200191610aec565b820191906000526020600020905b815481529060010190602001808311610acf57829003601f168201915b5050505060058301546006909301549192916001600160a01b0381169150600160a01b900460ff1688565b60028181548110610b2457fe5b9060005260206000209060070201600091509050806000015490806001015490806002018054600181600116156101000203166002900480601f016020809104026020016040519081016040528092919081815260200182805460018160011615610100020316600290048015610a555780601f10610a2a57610100808354040283529160200191610a55565b6000805b600a5481101561048f5782600d6000600a8481548110610bd157fe5b60009182526020808320909101546001600160a01b031683528201929092526040019020541415610c065760019150506103e6565b600101610bb5565b600060028281548110610c1d57fe5b9060005260206000209060070201600101543414610c3a57600080fd5b506001919050565b60405180610100016040528060008152602001600081526020016060815260200160008152602001606081526020016000815260200160006001600160a01b031681526020016000151581525090565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f10610cd357805160ff1916838001178555610d00565b82800160010185558215610d00579182015b82811115610d00578251825591602001919060010190610ce5565b50610d0c929150610dc5565b5090565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f10610d495780548555610d00565b82800160010185558215610d0057600052602060002091601f016020900482015b82811115610d00578254825591600101919060010190610d6a565b50805460018160011615610100020316600290046000825580601f10610dab5750610499565b601f01602090049060005260206000209081019061049991905b61068391905b80821115610d0c5760008155600101610dcb565b600082601f830112610def578081fd5b813567ffffffffffffffff80821115610e06578283fd5b604051601f8301601f191681016020018281118282101715610e26578485fd5b604052828152925082848301602001861015610e4157600080fd5b8260208601602083013760006020848301015250505092915050565b600060208284031215610e6e578081fd5b8135610e7981611107565b9392505050565b600060208284031215610e91578081fd5b5035919050565b60008060408385031215610eaa578081fd5b823591506020830135610ebc81611107565b809150509250929050565b60008060008060008060c08789031215610edf578182fd5b8635955060208701359450604087013567ffffffffffffffff80821115610f04578384fd5b610f108a838b01610ddf565b9550606089013594506080890135915080821115610f2c578384fd5b50610f3989828a01610ddf565b92505060a087013590509295509295509295565b60008151808452815b81811015610f7257602081850181015186830182015201610f56565b81811115610f835782602083870101525b50601f01601f19169290920160200192915050565b600061010082518452602083015160208501526040830151816040860152610fc282860182610f4d565b60608501516060870152608085015192508581036080870152610fe58184610f4d565b60a0868101519088015260c0808701516001600160a01b03169088015260e0958601511515959096019490945250929392505050565b6000602080830181845280855180835260408601915060408482028701019250838701855b8281101561106e57603f1988860301845261105c858351610f98565b94509285019290850190600101611040565b5092979650505050505050565b901515815260200190565b600060208252610e796020830184610f98565b90815260200190565b60006101008a83528960208401528060408401526110c28184018a610f4d565b88606085015283810360808501526110da8189610f4d565b60a08501979097525050506001600160a01b039290921660c0830152151560e09091015295945050505050565b6001600160a01b038116811461049957600080fdfea2646970667358221220ecda61bfd97743830c98bb505c8314431e041259775202f8a4b4338b3b00881464736f6c63430006010033";
        public MarketContractDeploymentBase() : base(BYTECODE) { }
        public MarketContractDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class BuyingHouseFunction : BuyingHouseFunctionBase { }

    [Function("buyingHouse", "bool")]
    public class BuyingHouseFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_idHome", 1)]
        public virtual BigInteger IdHome { get; set; }
        [Parameter("address", "_addressBuyer", 2)]
        public virtual string AddressBuyer { get; set; }
    }

    public partial class CreateHouseFunction : CreateHouseFunctionBase { }

    [Function("createHouse")]
    public class CreateHouseFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_id", 1)]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint256", "_price", 2)]
        public virtual BigInteger Price { get; set; }
        [Parameter("string", "_addressHome", 3)]
        public virtual string AddressHome { get; set; }
        [Parameter("uint256", "_squareMeter", 4)]
        public virtual BigInteger SquareMeter { get; set; }
        [Parameter("string", "_description", 5)]
        public virtual string Description { get; set; }
        [Parameter("uint256", "_hashDocuments", 6)]
        public virtual BigInteger HashDocuments { get; set; }
    }

    public partial class GetAllHousesWithDetailsFunction : GetAllHousesWithDetailsFunctionBase { }

    [Function("getAllHousesWithDetails", typeof(GetAllHousesWithDetailsOutputDTO))]
    public class GetAllHousesWithDetailsFunctionBase : FunctionMessage
    {

    }

    public partial class GetHouseFunction : GetHouseFunctionBase { }

    [Function("getHouse", typeof(GetHouseOutputDTO))]
    public class GetHouseFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_idHouse", 1)]
        public virtual BigInteger IdHouse { get; set; }
    }

    public partial class GetHouseForSaleFunction : GetHouseForSaleFunctionBase { }

    [Function("getHouseForSale", typeof(GetHouseForSaleOutputDTO))]
    public class GetHouseForSaleFunctionBase : FunctionMessage
    {

    }

    public partial class HouseForSaleFunction : HouseForSaleFunctionBase { }

    [Function("houseForSale")]
    public class HouseForSaleFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_idHouse", 1)]
        public virtual BigInteger IdHouse { get; set; }
    }

    public partial class HousesFunction : HousesFunctionBase { }

    [Function("houses", typeof(HousesOutputDTO))]
    public class HousesFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class OwnerToHouseFunction : OwnerToHouseFunctionBase { }

    [Function("ownerToHouse", "uint256")]
    public class OwnerToHouseFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class RemoveAtIndexFunction : RemoveAtIndexFunctionBase { }

    [Function("removeAtIndex")]
    public class RemoveAtIndexFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "index", 1)]
        public virtual BigInteger Index { get; set; }
    }





    public partial class GetAllHousesWithDetailsOutputDTO : GetAllHousesWithDetailsOutputDTOBase { }

    [FunctionOutput]
    public class GetAllHousesWithDetailsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple[]", "", 1)]
        public virtual List<House> ReturnValue1 { get; set; }
    }

    public partial class GetHouseOutputDTO : GetHouseOutputDTOBase { }

    [FunctionOutput]
    public class GetHouseOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual House ReturnValue1 { get; set; }
    }

    public partial class GetHouseForSaleOutputDTO : GetHouseForSaleOutputDTOBase { }

    [FunctionOutput]
    public class GetHouseForSaleOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "idHome", 1)]
        public virtual BigInteger IdHome { get; set; }
        [Parameter("uint256", "price", 2)]
        public virtual BigInteger Price { get; set; }
        [Parameter("string", "addressHome", 3)]
        public virtual string AddressHome { get; set; }
        [Parameter("uint256", "squareMeter", 4)]
        public virtual BigInteger SquareMeter { get; set; }
        [Parameter("string", "description", 5)]
        public virtual string Description { get; set; }
        [Parameter("uint256", "hashDocuments", 6)]
        public virtual BigInteger HashDocuments { get; set; }
        [Parameter("address", "publicAddressSolder", 7)]
        public virtual string PublicAddressSolder { get; set; }
        [Parameter("bool", "forSale", 8)]
        public virtual bool ForSale { get; set; }
    }



    public partial class HousesOutputDTO : HousesOutputDTOBase { }

    [FunctionOutput]
    public class HousesOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "idHome", 1)]
        public virtual BigInteger IdHome { get; set; }
        [Parameter("uint256", "price", 2)]
        public virtual BigInteger Price { get; set; }
        [Parameter("string", "addressHome", 3)]
        public virtual string AddressHome { get; set; }
        [Parameter("uint256", "squareMeter", 4)]
        public virtual BigInteger SquareMeter { get; set; }
        [Parameter("string", "description", 5)]
        public virtual string Description { get; set; }
        [Parameter("uint256", "hashDocuments", 6)]
        public virtual BigInteger HashDocuments { get; set; }
        [Parameter("address", "publicAddressSolder", 7)]
        public virtual string PublicAddressSolder { get; set; }
        [Parameter("bool", "forSale", 8)]
        public virtual bool ForSale { get; set; }
    }

    public partial class OwnerToHouseOutputDTO : OwnerToHouseOutputDTOBase { }

    [FunctionOutput]
    public class OwnerToHouseOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }


}
