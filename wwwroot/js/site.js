// Add.cshtml Subtype options

document.addEventListener("DOMContentLoaded", () => {
    const typeDropdown = document.getElementById("widgetType");

    const subtypeOneDropdown = document.getElementById("widgetSubtypeOne");
    const subtypeTwoDropdown = document.getElementById("widgetSubtypeTwo");
    const subtypeADropdown = document.getElementById("widgetSubtypeA");
    const subtypeBDropdown = document.getElementById("widgetSubtypeB");

    const subtypeMap = {
        One: subtypeOneDropdown,
        Two: subtypeTwoDropdown,
        A: subtypeADropdown,
        B: subtypeBDropdown
    }

    typeDropdown.addEventListener("change", () => {
        const dropdownArr = [subtypeOneDropdown, subtypeTwoDropdown, subtypeADropdown, subtypeBDropdown];

        for (const dropdown of dropdownArr) {
            dropdown.parentElement.style.display = "none";
            dropdown.disabled = true;
            dropdown.required = false;
        }

        const selectedType = typeDropdown.value;

        if (selectedType) {
            const selectedSubtype = subtypeMap[selectedType];
            selectedSubtype.parentElement.style.display = "block";
            selectedSubtype.disabled = false;
            selectedSubtype.required = true;
        }
    })
})