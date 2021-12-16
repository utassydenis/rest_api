<?php

include("connection.php");
$db = new dbObj();
$connection = $db->getConnstring();
$request_method = $_SERVER["REQUEST_METHOD"];

switch ($request_method) {
    case 'GET':
        if (!empty($_GET["id"])) {
            $id = intval($_GET["id"]);
            get_employeesid($id);
        } else {
            get_employees();
        }
        break;
    case 'POST':
        $id = $_GET["token"];
        if(tokenCheck($id)){
        insert_employee();
        }
        break;
    case 'PUT':
        $id = $_GET["token"];
        if(tokenCheck($id)){
            update_employee();
        }
        break;
    case 'DELETE':
        $id = $_GET["token"];
        if(tokenCheck($id)){
        //$id = intval($_GET["id"]);
        delete_employee();
        }
        break;
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}


function get_employees()
{
    global $connection;
    $query = "SELECT * FROM employee";
    $response = array();
    $result = mysqli_query($connection, $query);
    while ($row = mysqli_fetch_array($result)) {
        $response[] = $row;
    }
    header('Content-Type: application/json');
    echo json_encode($response);
}

function get_employeesid($id = 0)
{
    global $connection;
    $query = "SELECT * FROM employee";
    if ($id != 0) {
        $query .= " WHERE id=" . $id . " LIMIT 1";
    }
    $response = array();
    $result = mysqli_query($connection, $query);
    while ($row = mysqli_fetch_array($result)) {
        $response[] = $row;
    }
    header('Content-Type: application/json');
    echo json_encode($response);
}

function insert_employee()
{
    $db = new dbObj();
    $connection = $db->getConnstring();
    $data = json_decode(file_get_contents('php://input'), true);
    $employee_name = $data["employee_name"];
    $employee_salary = $data["employee_salary"];
    $employee_age = $data["employee_age"];
    echo $query = "INSERT INTO employee SET employee_name='" . $employee_name . "', employee_salary='" . $employee_salary . "', employee_age='" . $employee_age . "'";
    if (mysqli_query($connection, $query)) {
        $response = array(
            'status' => 1,
            'status_message' => 'Employee Added Successfully.'
        );
    } else {
        $response = array(
            'status' => 0,
            'status_message' => 'Employee Addition Failed.'
        );
    }
    header('Content-Type: application/json');
    echo json_encode($response);
}

function delete_employee()
{
    $db = new dbObj();
    $connection = $db->getConnstring();
    $data = json_decode(file_get_contents('php://input'), true);
    $id = $data["Id"];
    $query = "DELETE FROM employee WHERE id=" . $id;
    if (mysqli_query($connection, $query)) {
        $response = array(
            'status' => 1,
            'status_message' => 'Employee Deleted Successfully.'
        );
    } else {
        $response = array(
            'status' => 0,
            'status_message' => 'Employee Deletion Failed.'
        );
    }
    header('Content-Type: application/json');
    echo json_encode($response);
}


function update_employee()
{
    $db = new dbObj();
    $connection = $db->getConnstring();
    $post_vars = json_decode(file_get_contents("php://input"), true);
    $id = $post_vars["Id"];
    $employee_name = $post_vars["employee_name"];
    $employee_salary = $post_vars["employee_salary"];
    $employee_age = $post_vars["employee_age"];
    $query = "UPDATE employee SET employee_name='" . $employee_name . "', employee_salary='" . $employee_salary . "', employee_age='" . $employee_age . "' WHERE id=" . $id;
    if (mysqli_query($connection, $query)) {
        $response = array(
            'status' => 1,
            'status_message' => 'Employee Updated Successfully.'
        );
    } else {
        $response = array(
            'status' => 0,
            'status_message' => 'Employee Updation Failed.'
        );
    }
    header('Content-Type: application/json');
    echo json_encode($response);
}

function tokenCheck($token){
    $query = "SELECT * FROM token WHERE tokenString ='".$token."'";
    $response = responseValue($query);
    if(!empty($response)) {
        return true;
    }
    else
    {
        return false;
    }
}

function responseValue($query)
{
    global $connection;
    $statement = mysqli_prepare($connection,$query);
    $success = mysqli_stmt_execute($statement);
    $result = [];
    if($success === TRUE)
    {
        $tmp = $statement->get_result();
        while($temp = $tmp->fetch_assoc())
        {
            $result[]=$temp;
        }
    }
    else{
        echo $query;
        die('Sikertelen végrehajtás');
    }

    mysqli_stmt_close($statement);

    mysqli_close($connection);

    return $result;

}
?>