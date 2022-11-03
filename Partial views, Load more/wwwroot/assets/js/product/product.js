$(function () {
    $("#div3 img").mouseover(function () {
        document.getElementById("foto").src= this.src;
    })

    let scrollSection = document.getElementById("scroll-section");
   
    window.onscroll = function() {scrollFunction()};
 
    function scrollFunction() {
      if (document.body.scrollTop > 195|| document.documentElement.scrollTop > 195) {
         scrollSection.style.top = "0";
      } else {
         scrollSection.style.top = "-62px";
         $("div").removeClass("inActive");
      }
    }
})