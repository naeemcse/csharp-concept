using EntityFrameworkExample;

TrainingDbContext trainingDbContext = new TrainingDbContext();

/*************************************************************
 * Example 1 with single table 
 * **************************
Course course = new Course();
course.Title = "Professional ASP dot net";
course.Fees = 8000;
course.IsActive = true;
course.StartDate = new DateTime(2024, 3, 3);

// Insert Data

//trainingDbContext.Courses.Add(course);
trainingDbContext.SaveChanges();


// Get Data from database 

List <Course>  courses = trainingDbContext.Courses.ToList();
// hera var will same data type 
var activeCourses = trainingDbContext.Courses.Where(c => c.IsActive).ToList();
var csharpCourse = trainingDbContext.Courses.Where(x => x.Title.Contains("c#")).FirstOrDefault();
// First(), SingleOrSingle ( একাধিক থাকলে এরের করবে ) 
Console.WriteLine($"Id:{csharpCourse.Id}, Title : {csharpCourse.Title}");

/*
//Update Data // first get data then chage it 

csharpCourse.Fees = 30000;

trainingDbContext.SaveChanges();
*/

/*
// Delete data from database // first pickup then remove 

trainingDbContext.Courses.Remove(csharpCourse);

trainingDbContext.SaveChanges();
*/

/*************************************************************/


/********************************
 * One to Many Data insert
Course course = new Course();
course.Title = "Laravel";
course.Fees = 1200;
course.IsActive = true;
course.StartDate = new DateTime(2024, 10, 12);

Topics topics1 = new Topics();
topics1.Name = "Geting Start";
topics1.Duration = 120;

Topics topics2 = new Topics();
topics2.Name = "Basics Syntex";
topics2.Duration = 100;

course.Topics = new List<Topics>();
course.Topics.Add(topics1);
course.Topics.Add(topics2);

trainingDbContext.Courses.Add(course);
trainingDbContext.SaveChanges();

******************/

Course course = new Course();
course.Title = "DevOps";
course.Fees = 10000;
course.IsActive = true;
course.StartDate = new DateTime(2024, 3, 9);


Topics topics = new Topics();
topics.Name = "Basics Syntex";
topics.Duration = 200;

course.Topics = new List<Topics> { topics };

Student student = new Student();
student.Name = "Naeem";

Student student2 = new Student();
student2.Name = "Juthi";

StudentEnrollment enrollment = new StudentEnrollment();
enrollment.Student = student;
enrollment.Courses = course;

StudentEnrollment enrollment1 = new StudentEnrollment();
enrollment1.Student = student2;
enrollment1.Courses = course;

// Adding 
course.CourseStudnet = new List<StudentEnrollment> { enrollment , enrollment1};
trainingDbContext.Courses.Add(course);
trainingDbContext.SaveChanges();

