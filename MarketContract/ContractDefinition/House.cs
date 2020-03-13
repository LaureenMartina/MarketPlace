using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace MarketPlace.Contracts.MarketContract.ContractDefinition
{
    public partial class House : HouseBase { }

    public class HouseBase 
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
}
