string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

// Association des grade par rapport aux notes
int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

//Inisialise la variable qui permet d'incrémenter la somme
int totalCreditHours = 0;
//Incrémente la somme qui réprésente la nbr total d'heures de crédit
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

// Ou version one line
// totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

//Stocke le nbr total de pts obtenus pour chaque cours
int totalGradePoints = 0;
//Incrémente la somme des pts
totalGradePoints += course2Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

//Initialise la variable qui stock la MPC finale.
decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

//Pour afficher le premier chiffre de la MPC, une virgule décimal et les deux premiers chiffres après la décimal.

//Initialise la var qui stock le chiffe de début de la MPC.
int leadingDigit = (int) gradePointAverage;
//Initialise la var qui stock les deux primiers chiffres après la décimal.
int trailingDigits = (int) (gradePointAverage * 100) - (leadingDigit * 100);

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");
Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{trailingDigits}");