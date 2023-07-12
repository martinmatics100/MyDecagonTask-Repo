// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Select all animated sections
const animatedSections = document.querySelectorAll('.animate-section');

// Options for the Intersection Observer
const options = {
    root: null, // Use the viewport as the root
    threshold: 0.2, // Trigger the animation when 20% of the section is visible
};

// Callback function when an animated section is intersecting
const animateSectionCallback = (entries, observer) => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            entry.target.classList.add('animate');
        }
    });
};

// Create a new Intersection Observer
const observer = new IntersectionObserver(animateSectionCallback, options);

// Observe each animated section
animatedSections.forEach(section => {
    observer.observe(section);
});

