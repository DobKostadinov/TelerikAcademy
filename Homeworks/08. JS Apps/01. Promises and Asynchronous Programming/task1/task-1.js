(function () {
    let domElement = document.getElementById('location');

    function visualizePosition(position) {
        console.log(position);
        let src = 'http://maps.googleapis.com/maps/api/staticmap?center=' +
                position.coords.latitude +
                ',' +
                position.coords.longitude +
                '&zoom=16&size=500x500&sensor=false',
            img = document.createElement('img');

        img.setAttribute('src', src);

        domElement.appendChild(img);
    }
    
    function showError() {
        let p = document.createElement('p');
        p.innerHTML = 'Your location cannot be determined!';

        p.style.fontSize = '25px';
        p.style.color = 'red';

        domElement.appendChild(p);
    }

    let promise = new Promise((resolve, reject) => {
        navigator.geolocation.getCurrentPosition((data) => {
            resolve(data);
        }, () => {
            reject();
        });
    });

    promise
        .then(visualizePosition)
        .catch(showError);
})();