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
