'use strict';

angular.module('AddressBookApp').factory('AddressBookFactory', 
//app.factory('AddressBookFactory',
function AddressBookFactory($http) {

    function getAddresses() {
        return $http.get('/api/addresses');
    }

    var service = {
        getAddresses: getAddresses
    };

    return service;
});
