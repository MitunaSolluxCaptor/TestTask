function telCheck(e) {
    let test = /^\+7\([0-9]{3}\)[0-9]{3}\-[0-9]{2}\-[0-9]{2}/;
    if (!test.test(e.value)) {
        alert("Телефон не соответствует шаблону: +7(000)000-00-00");
    } else {
        return true;
    }
}
function press(e) {
    let parent = e.parentElement;
    e.remove();
    for (let i = 0; i < 2; i++) {
        parent.appendChild(e.cloneNode(true));
        e.innerText = e.innerText + " " + e.innerText;
    }
}
function selectPicture(e) {
    e.parentElement.classList.add("Select");
}
function addPicture(e) {
    event.preventDefault();
    let tmp = e.parentElement.cloneNode(true);
    tmp.childNodes[1].value = null;
    tmp.classList = "";
    e.parentElement.parentElement.appendChild(tmp);
 
}
function removePicture(e) {
    e.parentElement.remove();
}
function check() {
    event.preventDefault();
    let formData = new FormData(document.getElementById("form"));
    let counter = 0;
    for (let i = 5; i < form.childNodes[1].childNodes.length; i++) {
        if (form.childNodes[1].childNodes[i].classList == "Select") {
            counter++;
        }
    }
    if (telCheck(document.getElementById("tel")) && counter >= 2) {
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "https://localhost:44346/Home/Rec/");
        xhr.send(formData);
        xhr.onload = () => window.location.href = "https://localhost:44346/Home/Rec/";
    } else {
        alert("Необходимо загрузить хотя бы два файла. ");
    }
}