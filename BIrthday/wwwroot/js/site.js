document.addEventListener("DOMContentLoaded", function () {
    const reveals = document.querySelectorAll(".reveal");

    const observer = new IntersectionObserver(
        (entries) => {
            entries.forEach((entry) => {
                if (entry.isIntersecting) {
                    entry.target.classList.add("visible");
                }
            });
        },
        {
            threshold: 0.15,
        }
    );

    reveals.forEach((el) => observer.observe(el));
});
   

document.addEventListener("DOMContentLoaded", function () {

    const canvas = document.getElementById("ambientCanvas");
        if (!canvas) return;

        const ctx = canvas.getContext("2d");
        let particles = [];

        function resize() {
            canvas.width = window.innerWidth;
            canvas.height = window.innerHeight;
        }
           
    resize();
    window.addEventListener("resize", resize);

        const COLORS = [
        "rgba(180, 150, 255, 1.0)",
        "rgba(120, 185, 255, 1.0",
        "rgba(255, 180, 255, 1.0)",
    ];

    function createParticles(count) {
        particles = [];
        for (let i = 0; i < count; i++) {
            particles.push({
                x: Math.random() * canvas.width,
                y: Math.random() * canvas.height,
                r: 3+ Math.random() * 5,
                speedY: 0.03 + Math.random() * 0.1,
                alpha: 0.4 + Math.random() * 0.6,
                color: COLORS[Math.floor(Math.random() * COLORS.length)],
            });
        }
    }

    function draw() {
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        particles.forEach((p) => {
            p.y += p.speedY;
            if (p.y - p.r > canvas.height) {
                p.y = -p.r;
                p.x = Math.random() * canvas.width;
            }

            ctx.beginPath();
            const gradient = ctx.createRadialGradient(
                p.x,
                p.y,
                0,
                p.x,
                p.y,
                p.r * 4
            );
            gradient.addColorStop(
                0,
                p.color.replace("0.8", p.alpha.toFixed(2))
            );
            gradient.addColorStop(1, "rgba(0,0,0,0)");
            ctx.fillStyle = gradient;
            ctx.arc(p.x, p.y, p.r * 4, 0, Math.PI * 2);
            ctx.fill();
        });

        requestAnimationFrame(draw);
    }  
    createParticles(80);
    draw();

});
