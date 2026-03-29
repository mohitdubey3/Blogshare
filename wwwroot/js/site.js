(function () {
    var blogContent = document.getElementById("blogContent");
    var fontSizes = { small: "fs-6", normal: "fs-5", large: "fs-4", xlarge: "fs-3" };
    var sizeOrder = ["fs-6", "fs-5", "fs-4", "fs-3"];

    function stripFontClasses(el) {
        sizeOrder.forEach(function (c) { el.classList.remove(c); });
    }

    function applyFontSize(key) {
        var k = fontSizes[key] ? key : "normal";
        stripFontClasses(blogContent);
        blogContent.classList.add(fontSizes[k]);
        document.querySelectorAll("[data-size]").forEach(function (btn) {
            btn.classList.toggle("active", btn.getAttribute("data-size") === k);
        });
        localStorage.setItem("blogFontSize", k);
    }

    document.querySelectorAll("[data-size]").forEach(function (btn) {
        btn.addEventListener("click", function () {
            applyFontSize(btn.getAttribute("data-size"));
        });
    });
    document.getElementById("resetFontSize").addEventListener("click", function () {
        applyFontSize("normal");
    });

    applyFontSize(localStorage.getItem("blogFontSize") || "normal");

    var root = document.documentElement;
    function setTheme(mode) {
        root.setAttribute("data-bs-theme", mode === "dark" ? "dark" : "light");
        document.getElementById("darkModeBtn").classList.toggle("active", mode === "dark");
        document.getElementById("lightModeBtn").classList.toggle("active", mode !== "dark");
        localStorage.setItem("blogTheme", mode);
    }

    var prefersDark = window.matchMedia("(prefers-color-scheme: dark)").matches;
    setTheme(localStorage.getItem("blogTheme") || (prefersDark ? "dark" : "light"));

    document.getElementById("lightModeBtn").addEventListener("click", function () { setTheme("light"); });
    document.getElementById("darkModeBtn").addEventListener("click", function () { setTheme("dark"); });

    var progressBar = document.getElementById("readingProgressBar");
    function updateReadingProgress() {
        var doc = document.documentElement;
        var scrollTop = window.scrollY || doc.scrollTop;
        var height = doc.scrollHeight - doc.clientHeight;
        var p = height > 0 ? Math.min(100, Math.max(0, (scrollTop / height) * 100)) : 0;
        progressBar.style.width = p + "%";
        document.getElementById("readingProgress").setAttribute("aria-valuenow", Math.round(p));
    }
    window.addEventListener("scroll", updateReadingProgress, { passive: true });
    window.addEventListener("resize", updateReadingProgress);
    updateReadingProgress();
})();