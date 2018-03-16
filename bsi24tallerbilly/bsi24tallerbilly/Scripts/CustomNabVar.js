/*
* This scrip job is keep the nabvar when the user scrolls 20px from the top of the document
*/

//Event trigger
window.onscroll = function () { KeepNavbvar() };

function KeepNavbvar() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20)
    {
        document.getElementById("CustomNavbar").style.top = "0";
    }
    else
    {
        document.getElementById("CustomNavbar").style.top = "-50px";
    }
}