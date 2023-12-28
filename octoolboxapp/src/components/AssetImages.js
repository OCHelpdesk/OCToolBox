//React Native doesn’t deal with dynamic images, only static images. Therefore, you have to 
//front up all the images. You cannot construct the name and path dynamically. 

export class AssetImages {
    static GetUri = (imageId) => {
        var imgId = imageId.toLowerCase();
        var ret = null;
        switch (imgId) {
            case 'oc/pest/rodent':
                ret = require('../../assets/oc/pest/Rodent.jpg');
                break;
            case 'oc/pest/insect':
                ret = require('../../assets/oc/pest/Insect.jpg');
                break;
            case 'oc/pest/bird & wildlife':
                ret = require('../../assets/oc/pest/Pigeon.jpg');
                break;
            case 'oc/washroom care':
                ret = require('../../assets/oc/WashroomCare.jpg');
                break;
            case 'oc/ppe':
                ret = require('../../assets/oc/PPE.jpg');
                break;
            case 'oc/equipment':
                ret = require('../../assets/oc/Equipment.jpg');
                break;
            case 'oc/odour control':
                ret = require('../../assets/oc/OdourControl.jpg');
                break;
            case 'oc/cleaner':
                ret = require('../../assets/oc/Cleaner.jpg');
                break;
            case 'oc/drain maintenance':
                ret = require('../../assets/oc/DrainMaintenance.jpg');
                break;
            case 'oc/soak tank':
                ret = require('../../assets/oc/SoakTank.png');
                break;
            case 'oc/cigarette':
                ret = require('../../assets/oc/Cigarette.jpg');
                break;
            case 'oc/chemical':
                ret = require('../../assets/oc/Chemical.jpg');
                break;
            case 'oc/others':
                ret = require('../../assets/oc/OrkinOnSite.jpg');
                break;
            default:
                ret = require('../../assets/oc/OCLogo.png');
        }
        return ret;
    };
}