$(function () {

    // render math

    MathJax.Hub.Queue(function () {
        $(".math").each(function () {
            if ($(this).prop("tagName") == "SPAN") {                
                $(this).next(".math-alt, .math-alt-default").remove();
            } else {
                $(this).find("span:first-child").next(".math-alt, .math-alt-default").remove();
            }
            $(this).removeClass("math");
        });
    });

}); // document ready