pragma solidity >=0.4.21 <0.7.0;
pragma experimental ABIEncoderV2;

contract MarketContract {

    uint nbHouseAllowed = 3;
    uint countHouses = 0;

    // Caractéristiques d'une maison
    struct House {
        uint idHome;
        uint price;
        string addressHome;
        uint squareMeter;
        string description;
        uint hashDocuments; // une emprunte RGPD de la maison
        address publicAddressSolder;
        bool forSale;
        //others elements
    }

    event logger(uint);
    event logger(bool);
    event logger(address);

    House[] public houses;
    House public getHouseForSale;
    address[] owners;

    address houseOwner;
    address houseBuyer;

    mapping (address => uint) public ownerToHouse;
    mapping (address => uint) ownerHouseCount;
    mapping (address => uint256) public balanceOf;

    //vérifier si une maison appartient bien au bon propriétaire
    modifier onlyOwner(uint _idHome) {
        require(ownerToHouse[msg.sender] != _idHome);
        _;
    }

    // créer des maisons
    function createHouse(
        uint _id, uint _price, string memory _addressHome, uint _squareMeter, string memory _description, uint _hashDocuments
    ) public {
        House memory newHouse = House(_id, _price, _addressHome, _squareMeter, _description, _hashDocuments, msg.sender, false);
        houses.push(newHouse);
        ownerToHouse[msg.sender] = houses.length;
        countHouses++;
        owners.push(msg.sender);
    }

    // Vérifie si la maison est bien dans la liste des maisons à vendre
    function checkHouseForSale(uint _idHome) private view returns (bool) {
        for(uint i = 0; i < owners.length; i++) {
            if (ownerToHouse[owners[i]] == _idHome && houses[_idHome].forSale == true) {
                return true;
            }
        }
        return false;
    }

    // Vérifier le prix de la maison
    function checkPriceHouse(uint _idHouse) private returns (bool) {
        House memory house;
        for(uint i = 0; i < houses.length; i++) {
            if(houses[i].idHome == _idHouse) {
               house = houses[i];
            }
        }

        if (msg.value == house.price) return true;
        return false;
    }


    function removeAtIndex(uint index) public {
        if (index >= houses.length) return;

        for (uint i = index; i < houses.length-1; i++) {
        houses[i] = houses[i+1];
        }

        delete houses[houses.length-1];
        //houses.length--;
    }

    /* Send coins */
    // function transfer(address _to, uint256 _value) public {
    //     require(balanceOf[msg.sender] >= _value);           // Check if the sender has enough
    //     require(balanceOf[_to] + _value >= balanceOf[_to]); // Check for overflows
    //     balanceOf[msg.sender] -= _value;                    // Subtract from the sender
    //     balanceOf[_to] += _value;                           // Add the same to the recipient
    // }

    // function purchase of an hous
    // address payable => transférer
    // fct public payable => recevoir
    function buyingHouse(uint _idHome) public payable returns (bool) {
        if(checkHouseForSale(_idHome) && checkPriceHouse(_idHome)) { // checker si la maison est en vente, si le montant est correct
            //_addressBuyer.transfer(houses[_idHome].price); 
            require(msg.value != houses[_idHome].price);             // transfer ethers
            ownerToHouse[msg.sender] = _idHome;                      // transfert de propriété: obtenir la maison du vendeur et mettre l'addresse de l'acheteur
            removeAtIndex(_idHome);                                  // enlever la maison de la liste de ventes
            emit logger(checkHouseForSale(_idHome));
            emit logger(checkPriceHouse(_idHome));
            return true;
        }
        emit logger(checkHouseForSale(_idHome));
        emit logger(checkPriceHouse(_idHome));
        return false;
    }

    // Get all details of houses
    function getAllHousesWithDetails() public view returns(House[] memory) {
        return houses;
    }

    function getHouse(uint _idHouse) public view returns (House memory) {
        for(uint i = 0; i < houses.length; i++) {
            if(houses[i].idHome == _idHouse) {
                return houses[i];
            }
        }
    }

    // Put house for sale by an owner
    function houseForSale(uint _idHouse) public onlyOwner(_idHouse) {
        emit logger(houses.length);
       for(uint i = 0; i < houses.length; i++) {
            if(houses[i].idHome == _idHouse) {
                houses[i].forSale = true;
            }
        }
    }

    function getBalance() public view returns (uint) {
        return address(uint160(address(this))).balance;
    }
}