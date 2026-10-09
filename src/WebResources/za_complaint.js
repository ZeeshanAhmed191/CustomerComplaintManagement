function checkResolution(executionContext) {

    var formContext = executionContext.getFormContext();

    var status = formContext.getAttribute("za_status").getValue();
    var resolution = formContext.getAttribute("za_resolution");

    if (status == 4 || status == 5) {

        resolution.setRequiredLevel("required");

    } else {

        resolution.setRequiredLevel("none");

    }
}