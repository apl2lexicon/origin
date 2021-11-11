function check(checkbox) {
    var checkboxes = document.getElementsByName('color')
    checkboxes.forEach((item) => {
        if (item !== checkbox) item.checked = false;
    })
}