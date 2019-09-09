//...Get all books into the table #tblBokhylla...........................................
$(document).ready(function () {

    $("#tblBokhylla").hide();
    $.ajax({

        url: "http://localhost:53842/api/books",
        dataType: "json",
        type: "Get",
        contentType: "application/json; charset=utf-8",
        //data: { Title: Book },
        success: function (data) {
            var tr;
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                tr = tr + "<tr>";
                tr = tr + "<td>" + data[i].BookId + "</td>";
                tr = tr + "<td>" + data[i].Author + "</td>";
                tr = tr + "<td>" + data[i].Title + "</td>";
                tr = tr + "<td>" + data[i].Genre + "</td>";
                tr = tr + "<td>" + data[i].Publish_Date + "</td>";
                tr = tr + "<td>" + "$" + data[i].Price +  "</td>";
                tr = tr + "</tr>";
            }
            $('#tblBokhylla').append(tr);
            tblFormate();
        },
        error: function (xhr) {
            alert('No Valid Data');
        }
    });
})

//...Btn Show the full table #tblBokhylla.............................................................
$(document).ready(function () {
    $("#GetAllBooks").click(function () {
        $("#tblBokhylla").show();
    });
});

//...Btn Hide the table #tblBokhylla.............................................................
$(document).ready(function () {
    $("#HideAllBooks").click(function () {
        $("#tblBokhylla").hide();
    });
});



//Searching the html-table (#tblBokhylla) from a input named #search..................................................................
$(document).ready(function () {
    $("#search").keyup(function () {
        search_table($(this).val());
    });

    function search_table(value) {
        $("#tblBokhylla tr").each(function () {
            var found = "false";
            $(this).each(function(){
                
                if($(this).text().toLowerCase().indexOf(value.toLowerCase()) >= 0) 
                    {
                        found = "true";
                    $("#tblBokhylla").show();
                }

                });
            if (found == "true")
            {
                $(this).show();
            }
            else
            {
                $(this).hide();
            }
        });
    }
});
//..........................................................................................
