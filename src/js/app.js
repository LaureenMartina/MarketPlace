var Web3 = require("web3");

let result = null;
var web3js = window.web3;
var web3 = new Web3(web3js.currentProvider);

//var contract = require('truffle-contract');
const abi = [
    {
        "anonymous": false,
        "inputs": [
            {
                "indexed": false,
                "internalType": "uint256",
                "name": "",
                "type": "uint256"
            }
        ],
        "name": "logger",
        "type": "event"
    },
    {
        "anonymous": false,
        "inputs": [
            {
                "indexed": false,
                "internalType": "bool",
                "name": "",
                "type": "bool"
            }
        ],
        "name": "logger",
        "type": "event"
    },
    {
        "constant": true,
        "inputs": [
            {
                "internalType": "address",
                "name": "",
                "type": "address"
            }
        ],
        "name": "balanceOf",
        "outputs": [
            {
                "internalType": "uint256",
                "name": "",
                "type": "uint256"
            }
        ],
        "payable": false,
        "stateMutability": "view",
        "type": "function"
    },
    {
        "constant": true,
        "inputs": [],
        "name": "getHouseForSale",
        "outputs": [
            {
                "internalType": "uint256",
                "name": "idHome",
                "type": "uint256"
            },
            {
                "internalType": "uint256",
                "name": "price",
                "type": "uint256"
            },
            {
                "internalType": "string",
                "name": "addressHome",
                "type": "string"
            },
            {
                "internalType": "uint256",
                "name": "squareMeter",
                "type": "uint256"
            },
            {
                "internalType": "string",
                "name": "description",
                "type": "string"
            },
            {
                "internalType": "uint256",
                "name": "hashDocuments",
                "type": "uint256"
            },
            {
                "internalType": "address",
                "name": "publicAddressSolder",
                "type": "address"
            },
            {
                "internalType": "bool",
                "name": "forSale",
                "type": "bool"
            }
        ],
        "payable": false,
        "stateMutability": "view",
        "type": "function"
    },
    {
        "constant": true,
        "inputs": [
            {
                "internalType": "uint256",
                "name": "",
                "type": "uint256"
            }
        ],
        "name": "houses",
        "outputs": [
            {
                "internalType": "uint256",
                "name": "idHome",
                "type": "uint256"
            },
            {
                "internalType": "uint256",
                "name": "price",
                "type": "uint256"
            },
            {
                "internalType": "string",
                "name": "addressHome",
                "type": "string"
            },
            {
                "internalType": "uint256",
                "name": "squareMeter",
                "type": "uint256"
            },
            {
                "internalType": "string",
                "name": "description",
                "type": "string"
            },
            {
                "internalType": "uint256",
                "name": "hashDocuments",
                "type": "uint256"
            },
            {
                "internalType": "address",
                "name": "publicAddressSolder",
                "type": "address"
            },
            {
                "internalType": "bool",
                "name": "forSale",
                "type": "bool"
            }
        ],
        "payable": false,
        "stateMutability": "view",
        "type": "function"
    },
    {
        "constant": true,
        "inputs": [
            {
                "internalType": "address",
                "name": "",
                "type": "address"
            }
        ],
        "name": "ownerToHouse",
        "outputs": [
            {
                "internalType": "uint256",
                "name": "",
                "type": "uint256"
            }
        ],
        "payable": false,
        "stateMutability": "view",
        "type": "function"
    },
    {
        "constant": false,
        "inputs": [
            {
                "internalType": "uint256",
                "name": "_id",
                "type": "uint256"
            },
            {
                "internalType": "uint256",
                "name": "_price",
                "type": "uint256"
            },
            {
                "internalType": "string",
                "name": "_addressHome",
                "type": "string"
            },
            {
                "internalType": "uint256",
                "name": "_squareMeter",
                "type": "uint256"
            },
            {
                "internalType": "string",
                "name": "_description",
                "type": "string"
            },
            {
                "internalType": "uint256",
                "name": "_hashDocuments",
                "type": "uint256"
            }
        ],
        "name": "createHouse",
        "outputs": [],
        "payable": false,
        "stateMutability": "nonpayable",
        "type": "function"
    },
    {
        "constant": false,
        "inputs": [
            {
                "internalType": "uint256",
                "name": "index",
                "type": "uint256"
            }
        ],
        "name": "removeAtIndex",
        "outputs": [],
        "payable": false,
        "stateMutability": "nonpayable",
        "type": "function"
    },
    {
        "constant": false,
        "inputs": [
            {
                "internalType": "uint256",
                "name": "_idHome",
                "type": "uint256"
            },
            {
                "internalType": "address payable",
                "name": "_addressBuyer",
                "type": "address"
            }
        ],
        "name": "buyingHouse",
        "outputs": [
            {
                "internalType": "bool",
                "name": "",
                "type": "bool"
            }
        ],
        "payable": true,
        "stateMutability": "payable",
        "type": "function"
    },
    {
        "constant": true,
        "inputs": [],
        "name": "getAllHousesWithDetails",
        "outputs": [
            {
                "components": [
                    {
                        "internalType": "uint256",
                        "name": "idHome",
                        "type": "uint256"
                    },
                    {
                        "internalType": "uint256",
                        "name": "price",
                        "type": "uint256"
                    },
                    {
                        "internalType": "string",
                        "name": "addressHome",
                        "type": "string"
                    },
                    {
                        "internalType": "uint256",
                        "name": "squareMeter",
                        "type": "uint256"
                    },
                    {
                        "internalType": "string",
                        "name": "description",
                        "type": "string"
                    },
                    {
                        "internalType": "uint256",
                        "name": "hashDocuments",
                        "type": "uint256"
                    },
                    {
                        "internalType": "address",
                        "name": "publicAddressSolder",
                        "type": "address"
                    },
                    {
                        "internalType": "bool",
                        "name": "forSale",
                        "type": "bool"
                    }
                ],
                "internalType": "struct MarketContract.House[]",
                "name": "",
                "type": "tuple[]"
            }
        ],
        "payable": false,
        "stateMutability": "view",
        "type": "function"
    },
    {
        "constant": true,
        "inputs": [
            {
                "internalType": "uint256",
                "name": "_idHouse",
                "type": "uint256"
            }
        ],
        "name": "getHouse",
        "outputs": [
            {
                "components": [
                    {
                        "internalType": "uint256",
                        "name": "idHome",
                        "type": "uint256"
                    },
                    {
                        "internalType": "uint256",
                        "name": "price",
                        "type": "uint256"
                    },
                    {
                        "internalType": "string",
                        "name": "addressHome",
                        "type": "string"
                    },
                    {
                        "internalType": "uint256",
                        "name": "squareMeter",
                        "type": "uint256"
                    },
                    {
                        "internalType": "string",
                        "name": "description",
                        "type": "string"
                    },
                    {
                        "internalType": "uint256",
                        "name": "hashDocuments",
                        "type": "uint256"
                    },
                    {
                        "internalType": "address",
                        "name": "publicAddressSolder",
                        "type": "address"
                    },
                    {
                        "internalType": "bool",
                        "name": "forSale",
                        "type": "bool"
                    }
                ],
                "internalType": "struct MarketContract.House",
                "name": "",
                "type": "tuple"
            }
        ],
        "payable": false,
        "stateMutability": "view",
        "type": "function"
    },
    {
        "constant": false,
        "inputs": [
            {
                "internalType": "uint256",
                "name": "_idHouse",
                "type": "uint256"
            }
        ],
        "name": "houseForSale",
        "outputs": [],
        "payable": false,
        "stateMutability": "nonpayable",
        "type": "function"
    }
];

const address = "0x147a5d199c6aa307abdd77e487b125596dd67aa2";

//const Account = contract(Account_artifacts);

/*var web3js = window.web3;
var web3 = new Web3(web3js.currentProvider);

Account.setProvider(web3.currentProvider);
if (typeof Account.currentProvider.sendAsync !== "function") {
    Account.currentProvider.sendAsync = function() {
        return Account.currentProvider.send.apply(
            Account.currentProvider, arguments
        );
    };
}

Account.deployed();
Account.methods.getHouse().call();*/


var houseList = new Vue({
    el: "#houseList",
    data: {
        houses: [
            { id: "Blue house", price: "250 000", adressMarket: "6 rue du trouffion", squareMeter: "174m²", description: "pouet"},
            { id: "Blue house", price: "250 000", adressMarket: "6 rue du trouffion", squareMeter: "174m²", description: "pouet"},
            { id: "Blue house", price: "250 000", adressMarket: "6 rue du trouffion", squareMeter: "174m²", description: "pouet"}
        ]
    }
});

new Vue({
    el: '#createHouseForm',
    data: {
        errors: '',
        id: '',
        hashDocuments: '',
        price: '',
        address: '',
        surface: '',
        description: '',
        fields: false
    },
    methods: {
        getFormValues () {
            console.log("abi : ", abi);

            if(this.$refs.price.value && this.$refs.address.value && this.$refs.surface.value) {
                this.id = Math.ceil((Math.random() * 100) + 1);
                this.hashDocuments = Math.ceil((Math.random() * 100) + 1);
                this.price = this.$refs.price.value;
                this.address = this.$refs.address.value;
                this.surface = this.$refs.surface.value;
                this.description = this.$refs.description.value;

                this.fields = true;
            } else {
                this.errors = "Fields must not be null";
                this.fields = false;
            }
            console.log(this.errors)
            result = this.pouet();
            result.createHouse(this.id, this.price, this.address, this.surface, this.description, this.hashDocuments);

        },
        async pouet() {
            console.log(web3);
            var contract =   web3.eth.contract(abi);

            console.log("contract ", contract);

            const br = await contract.methods.getData.call();
            console.log(br);
            return result;
        }
    }
});




/*checkForm: function(e) {
    this.price = checkForm.form.price;
    console.log("price : ", this.price);

    this.price = createHouseForm.form.price;
    console.log("price : ", this.price);



    console.log("price : " + this.price);

    if(this.price && this.address && this.surface) {


        return true;
    }
   /* this.errors = [];

    if (!this.price) {
        this.errors.push("Price required");
    } else if (!this.address) {
        this.errors.push("Address required");
    } else if (!this.surface) {
        this.errors.push("Surface required");
    }  else if (!this.description) {
        this.errors.push("Description required");
    } else {
        console.log(this.price, this.address, this.surface, this.description);
    }
    e.preventDefault();
}*/
