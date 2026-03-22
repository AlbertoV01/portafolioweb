window.startScrollAnimation = () => {
    console.log("Intentando activar animaciones...");
    
    const elements = document.querySelectorAll('.reveal');
    
    // Si Blazor aún no pone los elementos en el HTML, reintentamos en 100ms
    if (elements.length === 0) {
        console.log("No hay elementos .reveal aún, reintentando...");
        setTimeout(window.startScrollAnimation, 100);
        return;
    }

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('active');
                console.log("Elemento visible:", entry.target.id);
            }
        });
    }, { threshold: 0.1 });

    elements.forEach(el => observer.observe(el));
};