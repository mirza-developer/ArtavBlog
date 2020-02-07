// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('.prevent-keydown').on('keydown', function (event) {
        event.preventDefault();
    });
    var map = L.map('map-address').setView([35.684252, 51.385119], 15); L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token={accessToken}', { attribution: '&copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a>, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a> © <a href="https://www.mapbox.com/">Mapbox</a>', maxZoom: 18, id: 'mapbox.streets', accessToken: 'sk.eyJ1IjoiYXJ0YXYiLCJhIjoiY2puNWw4bWh1MDNjNDNxcmZpajVoanB2NyJ9.OE3KMOYmhfxfbLdIdbHozQ' }).addTo(map); var marker = L.marker([35.683578, 51.386184]).addTo(map); marker.bindPopup("<b>مجموعه فرهنگی ورزشی کوثر</b><br>خیابان کاشان").openPopup();
});

