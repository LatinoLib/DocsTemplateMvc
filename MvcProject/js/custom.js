$(function () {

    // render math

    $(".math").after(function () {
        return $(this).prop("tagName") == "SPAN" ? 
            "<span class='writing-math'>Writing math ...</span>" :
            "<p class='writing-math'><span>Writing math ...</span></p>";
    });
    MathJax.Hub.Queue(function () {
        $(".math").each(function () {
            $(this).next(".writing-math").remove();
            $(this).removeClass("math");
        });
    });

}); // document ready