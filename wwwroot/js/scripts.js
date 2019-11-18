function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
    document.body.style.backgroundColor = "rgba(0,0,0,0.4)";
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
    document.body.style.backgroundColor = "white";
}

function moveSiteName() {
    var myVal = document.getElementById("btnNavigation").getAttribute("aria-expanded");
    if (myVal == "false") {
        document.getElementById("siteName").style.marginLeft = "0px";
    } else {
        document.getElementById("siteName").style.marginLeft = "90px";
    }
}
