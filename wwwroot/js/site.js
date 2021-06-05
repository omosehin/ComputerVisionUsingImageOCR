// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.;

function encodeImageFileAsURL() {

    var filesSelected = document.getElementById("inputFileToLoad").files;
    if (filesSelected.length > 0) {
        var fileToLoad = filesSelected[0];
        var fileReader = new FileReader();

        fileReader.onload = function (fileLoadedEvent) {
            var srcData = fileLoadedEvent.target.result; // <--- data: base64
            var base64result = srcData.split(',')[1];
            $.ajax({
                url: ' Home/GetImage',
                type: 'post',
                data: { baseImg: base64result },
                contentType: false,
                processData: false,
                success: function (response) {
                    if (response != 0) {
                        $("#img").attr("src", response);
                        $(".preview img").show(); // Display image element
                    } else {
                        alert('file not uploaded');
                    }
                },
            });
            
        }
        fileReader.readAsDataURL(fileToLoad);

    }
}
