pragma solidity >=0.4.21 <0.7.0;

contract MarketPlaceFactory {

    struct Home {
        uint idHome;
        uint price;
        string addressMarket; //bit32
        uint squareMeter;
        string description;
        string hashDocuments;
        string publicAddressSolder;
        //others;
    }

    Home[] public homes;

    // struct Purchase {
    //     uint id;
    //     string addressBuyer;
    // }
    mapping (uint => address) public ownerToHome;
    mapping (address => uint) ownerHomeCount;
    
    // vérifier si une maison appartient bien à un propriétaire 
    modifier checkValidity(uint _homeId) {
        require(ownerToHome[_homeId] == msg.sender);
        _;
    }

    function canCreateHome(uint _idHome) public view returns (bool) {
        uint count = 0;
        for(uint i = 0; i < ownerToHome[msg.sender].length; i++){
            if(homes[ownerToHome[msg.sender][i]].idHome == _idHome) count++;
        }

        return false;
    }

    // créer des maisons
    function createHome() public {
        if(canCreateHome(_homeId)) {

        }
    }


    // payable => recevoir des ethers    
    function buying(uint _idHome, string memory _addressBuyer) public payable checkValidity(_idHome) {
        // checker si la maison est en vente, si le montant est correct
        // transfer ethers
        // transfert de propriété
        // enlever la maison de la liste de ventes
    }

    // getAllHouses()
    // achat()
}