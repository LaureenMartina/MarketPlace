const MarketContract = artifacts.require("../contracts/MarketContract.sol");
const Web3 = require("web3");
let contractInstance;

contract('testCreateHouse', (accounts) => {
    beforeEach(async () => {
        contractInstance = await MarketContract.deployed()
    });

    // TEST CREATE HOUSE
    it('test creation of house', async () => {
        var addressPublic = { from: accounts[0] };
        const result = await contractInstance.createHouse(56, Web3.utils.toWei('3', 'ether') , "12 rue de la fourchette", 120, "belle maison", 1234, addressPublic );
        const getHouse = await contractInstance.getHouse(56);
        //console.log("getHouse:", getHouse);
        assert.equal(getHouse.addressHome, "12 rue de la fourchette");
    });


    // TEST PUT FOR SALE
    it('test put house for sale', async () => {
        var addressPublic = { from: accounts[0] };
        const result = await contractInstance.houseForSale(56, addressPublic);
        const getHouse = await contractInstance.getHouse.call(56);
        //console.log("result put for sale:", getHouse);
        assert.equal(getHouse.forSale, true);
    });


    // // TEST BUYING (PURCHASE)
    it('test purchase house', async () => {
        var addressPublic = { from: accounts[0] };
        //var myAddressPublic = 0xDEeCb6fd17d8130608e8689626FeddA795f41a07;
        const result = await contractInstance.buyingHouse(56, { from: accounts[0], value: Web3.utils.toWei('3', 'ether') });
        console.log("result purchase:", result);

        // return contractInstance.buyingHouse(123456, addressPublic.from)
        //     .then(assert.fail).catch(function (error) {
        //         assert(error.message.indexOf('revert') >= 0, "error message must contain revert");
        //     });
    });
})