'use strict';

angular.module('AddressBookApp').controller('AddressBookController',
    function AddressBookController($scope, AddressBookFactory) {
    $scope.addresses = []; // о, волшебная строчка! Без объявления переменной как массива данные передавались не в виде массива объектов, а как объект с массивом внутри.

    AddressBookFactory.getAddresses().then(function (addresses) {
        $scope.addresses = addresses;
        //$scope.addresses = [{ id: 1, dateCreate: "2017-06-09T01:42:08.123", country: "Россия", city: "Ульяновск", street: "Маяковского", house: 1, postIndex: "432071" }, { id: 2, dateCreate: "2017-06-09T01:42:08.123", country: "Россия", city: "Москва", street: "Ленина", house: 5, postIndex: "123000" }, { id: 3, dateCreate: "2017-06-09T01:42:08.123", country: "Россия", city: "Санкт-Петербург", street: "Невский пр-т.", house: 14, postIndex: "587235" }, { id: 4, dateCreate: "2017-06-09T01:42:08.123", country: "Россия", city: "Киев", street: "Б. Хитрово", house: 48, postIndex: "025874" }, { id: 5, dateCreate: "2017-06-09T01:42:08.123", country: "Россия", city: "Ульяновск", street: "Любови Шевцовой", house: 54, postIndex: "432025" }];
        //
    },function (error) {
        // log errors
    });
});
