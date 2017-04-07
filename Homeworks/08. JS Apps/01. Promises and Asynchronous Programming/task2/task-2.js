let domElement = document.getElementById('popup'),
    promise = new Promise((resolve, reject) => {
        resolve();
    });

function displayPopup() {
    domElement.style.display = 'block';
}

function delayTwoSeconds() {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve();
        }, 2000);
    });
}

function hidePopup() {
    domElement.style.display = '';
}

function redirectToAnotherSite() {
    document.location = 'http://academy.telerik.com/';
}

promise
    .then(displayPopup)
    .then(delayTwoSeconds)
    .then(hidePopup)
    .then(redirectToAnotherSite);

