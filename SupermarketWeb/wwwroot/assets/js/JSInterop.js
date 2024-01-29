window.loadDashboardScript = function (scriptUrl) {
    var scriptElement = document.createElement('script');
    scriptElement.src = scriptUrl;
    if(scriptUrl != "assets/js/eco-dashboard.js" && scriptUrl != "assets/js/scripts.js")
        scriptElement.async = true;
    document.head.appendChild(scriptElement);
};

window.setCookie = function setCookie(name, value, seconds) {
    var date = new Date();
    date.setTime(date.getTime() + (seconds * 1000));
    var expires = "; expires=" + date.toUTCString();
    document.cookie = name + "=" + value + expires + "; path=/";
}

window.getCookie = function getCookie(name) {
    const cookies = document.cookie.split(';');
    
    for (let i = 0; i < cookies.length; i++) {
        const cookie = cookies[i].trim();
        if (cookie.startsWith(name + '=')) {
            return cookie.substring(name.length + 1);
        }
    }
    
    // Return null if the cookie is not found
    return null;
}

window.removeCookie = function removeCookie(key) {
    document.cookie = key + "=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
}

window.openModal = function openModal(id) {
    // Your modal opening logic here
    // Example using Bootstrap modal
    $('#'+id).modal('show');
}

window.closeModal = function closeModal(id) {
    // Your modal opening logic here
    // Example using Bootstrap modal
    $('#'+id).modal('hide');
}

window.setupBarcodeScanner = async () => {
    const videoElement = document.createElement('video');
    document.getElementById('barcode-scanner').appendChild(videoElement);

    const constraints = { video: { facingMode: 'environment' } };
    const stream = await navigator.mediaDevices.getUserMedia(constraints);
    videoElement.srcObject = stream;

    const codeReader = new ZXing.BrowserQRCodeReader();

    codeReader.decodeFromVideoDevice(undefined, videoElement, (result, err) => {
        if (result) {
            DotNet.invokeMethodAsync('YourBlazorApp', 'BarcodeScanned', result.text);
        }
    });
};

window.playSound = function (soundUrl) {
    var audio = new Audio(soundUrl);
    audio.play();
};

function getPath(){
    var currentPath = window.location.pathname;
    return currentPath+'#';
}

window.reloadPage = function () {
    location.reload(true);
};

window.initializeSelectPicker = (selectElement) => {
    $(selectElement).selectpicker();
};

window.printPage = function () {
    window.print();
};

window.openInNewTab = function (url) {
    window.open(url, '_blank');
};