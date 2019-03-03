var app = angular.module("nearbyPlacesList", []);

app.controller("nearbyPlacesController", function ($scope) {
    $scope.getClick = function () {

        var latitude = $scope.latitude;
        var longitude = $scope.longitude;
        var radius = $scope.radius;

        getPlaces(latitude, longitude, radius);
    };

    $scope.removeItem = function (index) {
        $scope.places.splice(index, 1);
    }

    function getPlaces(latitude, longitude, radius) {
        var places = [];

        $.ajax({
            type: "GET",
            url: "http://nearbyplaceswebapi.azurewebsites.net/api/Places/GetNearbyPlaces?latitude=" + latitude + "&longitude=" + longitude + "&radius=" + radius,
            contentType: "application/json; charset=utf-8",
            datatype: "json",
            async: false,
            success: function (data) {
                if (data.Places == null) {
                    alert("Could not reach to redis server!");
                }
                else {
                    for (var i = 0; i < data.Places.length; i++) {
                        places.push(data.Places[i]);
                    }

                    if (places.length == 0) {
                        alert("No places found!");
                    }

                    $scope.places = places;
                }
            },
            error: function (xhr, textStatus, errorThrown) {
                alert("An error occured when retrieving nearby places!");
            }
        });
    }
});