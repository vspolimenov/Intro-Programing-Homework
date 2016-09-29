package bg.jwd.university.entities;

public class Student {
	private long id;
	private String facultyNo;
	private String name;

	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

	public String getFacultyNo() {
		return facultyNo;
	}

	public void setFacultyNo(String facultyNo) {
		this.facultyNo = facultyNo;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
}