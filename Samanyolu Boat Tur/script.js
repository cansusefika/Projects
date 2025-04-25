// script.js
let modal = document.getElementById('myModal');
let modalImg = document.getElementById('img01');
let captionText = document.getElementById('caption');
let images = document.querySelectorAll('.gallery-item');
let currentIndex = 0;

images.forEach((img, index) => {
    img.addEventListener('click', function() {
        modal.style.display = 'block';
        modal.style.visibility= visible;
        modalImg.src = this.src;
        captionText.innerHTML = this.alt;
        currentIndex = index;
    });
});

let span = document.getElementsByClassName('close')[0];
span.onclick = function() {
    modal.style.display = 'none';
}

function showImage(index) {
    if (index >= images.length) {
        currentIndex = 0;
    } else if (index < 0) {
        currentIndex = images.length - 1;
    } else {
        currentIndex = index;
    }
    modalImg.src = images[currentIndex].src;
    captionText.innerHTML = images[currentIndex].alt;
}

let prev = document.querySelector('.prev');
let next = document.querySelector('.next');

prev.addEventListener('click', function() {
    showImage(currentIndex - 1);
});

next.addEventListener('click', function() {
    showImage(currentIndex + 1);
});

document.addEventListener('keydown', function(event) {
    if (event.key === 'ArrowLeft') {
        showImage(currentIndex - 1);
    } else if (event.key === 'ArrowRight') {
        showImage(currentIndex + 1);
    } else if (event.key === 'Escape') {
        modal.style.display = 'none';
    }
});

modal.addEventListener('click', function(event) {
    if (event.target === modal) {
        modal.style.display = 'none';
    }
});
