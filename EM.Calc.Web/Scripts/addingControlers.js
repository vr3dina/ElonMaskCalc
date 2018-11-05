addInputAfter(this);

function keyPressed(e) {
    var keyCode;

    if (this.event) {
        keyCode = this.event.keyCode;
    }
    else if (e) {
        keyCode = e.which;
    }

    if (keyCode == 32) {
        addInputAfter(this);
    }

    var args = document.getElementsByName("Args");
    if (this.value.length == 0 && keyCode == 8 && args.length > 1) {
        var focusEl = this.previousSibling;
        document.getElementById("inputNumbers").removeChild(this);
        focusEl.focus();
    }
}

function addInputAfter(el) {
    var cont = document.getElementById("inputNumbers");
    var input = document.createElement("input");
    input.type = "number";
    input.name = "Args";
    input.className = "form-control";
    input.addEventListener("keydown", keyPressed);
    cont.insertBefore(input, el.nextSibling).focus();
}