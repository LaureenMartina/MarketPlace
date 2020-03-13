import {Model, Collection} from 'vue-mc'

export class House extends Model {
    defaults() {
        return {
            //idHome: null,
            price: null,
            address: '',
            squareMeter: null,
            //description: '',
            //hashDocuments: ''
        }
    }

}