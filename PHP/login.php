<?php
include("connection.php");
$db = new dbObj();
$connection =  $db->getConnstring();
$request_method=$_SERVER["REQUEST_METHOD"];

switch ($request_method){
    case 'POST':
        if(!empty($_GET["login"])){
            login();
        }
        elseif (!empty($_GET["logout"])){
            logout();
        }
}

function login(){
    $post_vars = json_decode(file_get_contents("php://input"),true);
    $user=$post_vars["username"];
    $pass=$post_vars["password"];

    $query = "SELECT * FROM login WHERE username='".$user."' AND password='".$pass."'";

    $result=responseValue($query);

    if(!empty($result)) {
        $token = create_token();
        $response = array(
            'status' => 1,
            'status_message' => $token
        );
        echo json_encode($response);
    }
    else
    {
        $response = array(
            'status' => 0,
            'status_message' => 'Login Failed!'
        );
        echo json_encode($response);
    }
    header('Content-Type: application/json');
}

function logout()
{
    $post_vars = json_decode(file_get_contents("php://input"),true);
    $db = new dbObj();
    $connection =  $db->getConnstring();
    $token = $post_vars["token"];
    $query = "DELETE FROM token WHERE tokenString='".$token."'";
    if($connection -> query($query) === TRUE){

    }
    else{

    }
    $response = array(
        'status' => 1,
        'status_message' => 'Logout Successful!',
    );
    echo json_encode($response);
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

function create_token($n = 10){
    $characters = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';
    $randomString = '';

    for ($i = 0; $i < $n; $i++) {
        $index = rand(0, strlen($characters) - 1);
        $randomString .= $characters[$index];
    }
    insert_token($randomString);
    return $randomString;
}

function insert_token($token){
    $db = new dbObj();
    $connection =  $db->getConnstring();
    $query = "INSERT INTO token(tokenString) VALUES ('".$token."')";
    if($connection -> query($query) === TRUE){

    }
    else{

    }
}
?>