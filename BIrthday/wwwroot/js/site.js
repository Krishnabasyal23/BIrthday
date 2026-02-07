document.addEventListener("DOMContentLoaded", function ()=> {
//    const reveals = document.querySelectorAll(".reveal");

//    const observer = new IntersectionObserver(
//        (entries) => {
//    entries.forEach((entry) => {
//        if (entry.isIntersecting) {
//            entry.target.classList.add("visible");
//        }
//    });

//    ),
//    {
//        threshold: 0.15,
//    }
//);
    //    reveals.forEach(el => observer.observe(el));

    const canvas = document.getElementById("ambientCanvas");
    const ctx = canvs..getCoontesxt("2d");
    let w, h;
    function resize(){
    w=canvas.width = window.innerWidth;
    h=canvas.height = window.innerHeight;
}
     window.addEventListener("resize", resize);
resize();

const particles = Array.from({ length: 50 }, () => ({
    x: Math.random() * w,
    y: Math.random() * h,
    r: Math.random() * 1.5 + 0.5,
    vx: (Math.random() - 0.5) * 0.2,
    vy: (Math.random() - 0.5) * 0.2,
    alpha: Math.random() * 0.5 + 0.2
}));

function animate() {
    ctx.clearRect(0, 0, w, h);
    particles.forEach(p => {
        p.x += p.vx;
        p.y += p.vy;
        if (p.x < 0 || p.x > w) p.vx *= -1;
        if (p.y < 0 || p.y > h) p.vy *= -1;

        ctx.beginPath();
        ctx.arc(p.x, p.y, p.r, 0, Math.PI * 2);
        ctx.fillStyle = `rgba(255, 255, 255, ${p.alpha})`;
        ctx.fill();

    });
    requestAnimationFrame(animate);
}
animate();

});