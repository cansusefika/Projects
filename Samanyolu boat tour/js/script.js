document.addEventListener('DOMContentLoaded', function() {
    const modal = document.getElementById('galleryModal');
    const modalImage = document.getElementById('modalImage');
    const caption = document.getElementById('caption');
    const closeBtn = document.querySelector('.close');
    const prevBtn = document.getElementById('prev');
    const nextBtn = document.getElementById('next');
    const galleryItems = document.querySelectorAll('.gallery-item');
    let currentIndex = 0;

    function openModal(index) {
        modal.style.display = 'flex';
        currentIndex = index;
        showImage(currentIndex);
    }

    function closeModal() {
        modal.style.display = 'none';
    }

    function showImage(index) {
        modalImage.src = galleryItems[index].src;
        caption.textContent = galleryItems[index].alt;
    }

    function nextImage() {
        currentIndex = (currentIndex + 1) % galleryItems.length;
        showImage(currentIndex);
    }

    function prevImage() {
        currentIndex = (currentIndex - 1 + galleryItems.length) % galleryItems.length;
        showImage(currentIndex);
    }

    galleryItems.forEach((item, index) => {
        item.addEventListener('click', () => openModal(index));
    });

    closeBtn.addEventListener('click', closeModal);
    nextBtn.addEventListener('click', nextImage);
    prevBtn.addEventListener('click', prevImage);

    // Close modal when clicking outside of the image
    modal.addEventListener('click', (e) => {
        if (e.target === modal) {
            closeModal();
        }
    });

    // Navigation with arrow keys
    document.addEventListener('keydown', (e) => {
        if (modal.style.display === 'flex') {
            if (e.key === 'ArrowRight') {
                nextImage();
            } else if (e.key === 'ArrowLeft') {
                prevImage();
            } else if (e.key === 'Escape') {
                closeModal();
            }
        }
    });
});
