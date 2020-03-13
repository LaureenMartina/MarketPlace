using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using MarketPlace.Contracts.MarketContract.ContractDefinition;

namespace MarketPlace.Contracts.MarketContract
{
    public partial class MarketContractService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, MarketContractDeployment marketContractDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<MarketContractDeployment>().SendRequestAndWaitForReceiptAsync(marketContractDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, MarketContractDeployment marketContractDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<MarketContractDeployment>().SendRequestAsync(marketContractDeployment);
        }

        public static async Task<MarketContractService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, MarketContractDeployment marketContractDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, marketContractDeployment, cancellationTokenSource);
            return new MarketContractService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public MarketContractService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> BuyingHouseRequestAsync(BuyingHouseFunction buyingHouseFunction)
        {
             return ContractHandler.SendRequestAsync(buyingHouseFunction);
        }

        public Task<TransactionReceipt> BuyingHouseRequestAndWaitForReceiptAsync(BuyingHouseFunction buyingHouseFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(buyingHouseFunction, cancellationToken);
        }

        public Task<string> BuyingHouseRequestAsync(BigInteger idHome, string addressBuyer)
        {
            var buyingHouseFunction = new BuyingHouseFunction();
                buyingHouseFunction.IdHome = idHome;
                buyingHouseFunction.AddressBuyer = addressBuyer;
            
             return ContractHandler.SendRequestAsync(buyingHouseFunction);
        }

        public Task<TransactionReceipt> BuyingHouseRequestAndWaitForReceiptAsync(BigInteger idHome, string addressBuyer, CancellationTokenSource cancellationToken = null)
        {
            var buyingHouseFunction = new BuyingHouseFunction();
                buyingHouseFunction.IdHome = idHome;
                buyingHouseFunction.AddressBuyer = addressBuyer;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(buyingHouseFunction, cancellationToken);
        }

        public Task<string> CreateHouseRequestAsync(CreateHouseFunction createHouseFunction)
        {
             return ContractHandler.SendRequestAsync(createHouseFunction);
        }

        public Task<TransactionReceipt> CreateHouseRequestAndWaitForReceiptAsync(CreateHouseFunction createHouseFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createHouseFunction, cancellationToken);
        }

        public Task<string> CreateHouseRequestAsync(BigInteger id, BigInteger price, string addressHome, BigInteger squareMeter, string description, BigInteger hashDocuments)
        {
            var createHouseFunction = new CreateHouseFunction();
                createHouseFunction.Id = id;
                createHouseFunction.Price = price;
                createHouseFunction.AddressHome = addressHome;
                createHouseFunction.SquareMeter = squareMeter;
                createHouseFunction.Description = description;
                createHouseFunction.HashDocuments = hashDocuments;
            
             return ContractHandler.SendRequestAsync(createHouseFunction);
        }

        public Task<TransactionReceipt> CreateHouseRequestAndWaitForReceiptAsync(BigInteger id, BigInteger price, string addressHome, BigInteger squareMeter, string description, BigInteger hashDocuments, CancellationTokenSource cancellationToken = null)
        {
            var createHouseFunction = new CreateHouseFunction();
                createHouseFunction.Id = id;
                createHouseFunction.Price = price;
                createHouseFunction.AddressHome = addressHome;
                createHouseFunction.SquareMeter = squareMeter;
                createHouseFunction.Description = description;
                createHouseFunction.HashDocuments = hashDocuments;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createHouseFunction, cancellationToken);
        }

        public Task<GetAllHousesWithDetailsOutputDTO> GetAllHousesWithDetailsQueryAsync(GetAllHousesWithDetailsFunction getAllHousesWithDetailsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetAllHousesWithDetailsFunction, GetAllHousesWithDetailsOutputDTO>(getAllHousesWithDetailsFunction, blockParameter);
        }

        public Task<GetAllHousesWithDetailsOutputDTO> GetAllHousesWithDetailsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetAllHousesWithDetailsFunction, GetAllHousesWithDetailsOutputDTO>(null, blockParameter);
        }

        public Task<GetHouseOutputDTO> GetHouseQueryAsync(GetHouseFunction getHouseFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetHouseFunction, GetHouseOutputDTO>(getHouseFunction, blockParameter);
        }

        public Task<GetHouseOutputDTO> GetHouseQueryAsync(BigInteger idHouse, BlockParameter blockParameter = null)
        {
            var getHouseFunction = new GetHouseFunction();
                getHouseFunction.IdHouse = idHouse;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetHouseFunction, GetHouseOutputDTO>(getHouseFunction, blockParameter);
        }

        public Task<GetHouseForSaleOutputDTO> GetHouseForSaleQueryAsync(GetHouseForSaleFunction getHouseForSaleFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetHouseForSaleFunction, GetHouseForSaleOutputDTO>(getHouseForSaleFunction, blockParameter);
        }

        public Task<GetHouseForSaleOutputDTO> GetHouseForSaleQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetHouseForSaleFunction, GetHouseForSaleOutputDTO>(null, blockParameter);
        }

        public Task<string> HouseForSaleRequestAsync(HouseForSaleFunction houseForSaleFunction)
        {
             return ContractHandler.SendRequestAsync(houseForSaleFunction);
        }

        public Task<TransactionReceipt> HouseForSaleRequestAndWaitForReceiptAsync(HouseForSaleFunction houseForSaleFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(houseForSaleFunction, cancellationToken);
        }

        public Task<string> HouseForSaleRequestAsync(BigInteger idHouse)
        {
            var houseForSaleFunction = new HouseForSaleFunction();
                houseForSaleFunction.IdHouse = idHouse;
            
             return ContractHandler.SendRequestAsync(houseForSaleFunction);
        }

        public Task<TransactionReceipt> HouseForSaleRequestAndWaitForReceiptAsync(BigInteger idHouse, CancellationTokenSource cancellationToken = null)
        {
            var houseForSaleFunction = new HouseForSaleFunction();
                houseForSaleFunction.IdHouse = idHouse;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(houseForSaleFunction, cancellationToken);
        }

        public Task<HousesOutputDTO> HousesQueryAsync(HousesFunction housesFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<HousesFunction, HousesOutputDTO>(housesFunction, blockParameter);
        }

        public Task<HousesOutputDTO> HousesQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var housesFunction = new HousesFunction();
                housesFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryDeserializingToObjectAsync<HousesFunction, HousesOutputDTO>(housesFunction, blockParameter);
        }

        public Task<BigInteger> OwnerToHouseQueryAsync(OwnerToHouseFunction ownerToHouseFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerToHouseFunction, BigInteger>(ownerToHouseFunction, blockParameter);
        }

        
        public Task<BigInteger> OwnerToHouseQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var ownerToHouseFunction = new OwnerToHouseFunction();
                ownerToHouseFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<OwnerToHouseFunction, BigInteger>(ownerToHouseFunction, blockParameter);
        }

        public Task<string> RemoveAtIndexRequestAsync(RemoveAtIndexFunction removeAtIndexFunction)
        {
             return ContractHandler.SendRequestAsync(removeAtIndexFunction);
        }

        public Task<TransactionReceipt> RemoveAtIndexRequestAndWaitForReceiptAsync(RemoveAtIndexFunction removeAtIndexFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeAtIndexFunction, cancellationToken);
        }

        public Task<string> RemoveAtIndexRequestAsync(BigInteger index)
        {
            var removeAtIndexFunction = new RemoveAtIndexFunction();
                removeAtIndexFunction.Index = index;
            
             return ContractHandler.SendRequestAsync(removeAtIndexFunction);
        }

        public Task<TransactionReceipt> RemoveAtIndexRequestAndWaitForReceiptAsync(BigInteger index, CancellationTokenSource cancellationToken = null)
        {
            var removeAtIndexFunction = new RemoveAtIndexFunction();
                removeAtIndexFunction.Index = index;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeAtIndexFunction, cancellationToken);
        }
    }
}
